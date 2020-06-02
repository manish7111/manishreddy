import React, { Component } from 'react';
import DashBoard from '../Components/dashboard.js';
import { getAllItems, deleteProduct, updateProduct, addDescriptions,addSizes,addColors } from '../Controller/services.js';
import Cropper from 'react-cropper';
import 'cropperjs/dist/cropper.css';
import Select from 'react-select';

export default class GetAllProducts extends Component {
    constructor(props) {
        super(props);
        this.state = {
            items: [],
            updateCard: false,
            addItemOpen: false,
            itemId: "",
            itemName: "",
            description1: "",
            description2: "",
            advantage:"",
            itemImage: null,
            price: "",
            Image: "",
            itemSize: "",
            itemColor: ""
        }
    }
    componentDidMount() {
        this.getAllProducts();
    }
    getAllProducts = () => {
        getAllItems().then((response) => {
            this.setState({
                items: response.data
            })
            console.log("list of items", this.state.items);
        })
    }
    handleUpdateItem = async (key) => {
        this.setState({
            updateCard: true,
            itemId: key.itemId,
            itemName: key.itemName,
            itemBrandName: key.itemBrandName,
            itemImage: key.itemImage,
            price: key.price,
            Image: key.itemImage,
        })
    }
    handleUpdateApply = () => {
        var data = {
            itemId: this.state.itemId,
            itemName: this.state.itemName,
            itemBrandName: this.state.itemBrandName,
            price: this.state.price,
            itemImage: this.state.itemImage
        }
        console.log("data", data)
        updateProduct(data).then((response) => {
            this.setState({
                addItemOpen: true,
                spinner: false
            })
            console.log("Update Product response====>", response);
            window.location.reload();
        })
            .catch((err) => {
                console.log("error occured while updating----------", err);
            });
    }
    handleDeleteItem = (data) => {
        deleteProduct(data).then((response) => {
            if (response) {
                this.getAllProducts();
            }
        })
    }
    handleChange = (e) => {
        e.preventDefault();
        let files;
        if (e.dataTransfer) {
            files = e.dataTransfer.files;
        } else if (e.target) {
            files = e.target.files;
        }
        const reader = new FileReader();
        reader.onload = () => {
            this.setState({ Image: reader.result });
        };
        reader.readAsDataURL(files[0]);
    }
    handleCrop = () => {
        if (typeof this.cropper.getCroppedCanvas() === 'undefined') {
            return;
        }
        this.setState({
            itemImage: this.cropper.getCroppedCanvas().toDataURL(),
        });
        console.log("crop Image", this.state.itemImage);
    }
    handleProductName = (event) => {
        let data = event.target.value;
        this.setState({
            itemName: data
        })
    }
    handleDescription1 = (event) => {
        let data = event.target.value;
        this.setState({
            description1: data
        })
    }
    handleDescription2 = (event) => {
        let data = event.target.value;
        this.setState({
            description2: data
        })
    }
    handleAdvantage = (event) => {
        let data = event.target.value;
        this.setState({
            advantage: data
        })
    }
    handleProductPrice = (event) => {
        let data = event.target.value;
        this.setState({
            price: data
        })
    }
    handleCancel = () => {
        this.setState({
            updateCard: false
        })
    }
    handleColorChange = (event, id) => {
        event.preventDefault();
        if (event.target.id == id) {
            let item = event.target.value;
            this.setState({
                itemColor: item,
                itemId:id
            })
        }
    }
    handleSizeChange = async (event, id) => {
        let item = event.value;
        console.log("item data", item);
        await this.setState({
            itemSize: item,
            itemId:id
        })
    }
    handleTotalDescription=(id)=>{
        var data={
            itemId:id,
            description1:this.state.description1,
            description2:this.state.description2,
            advantage:this.state.advantage
        }
        addDescriptions(data).then((response) => {
            console.log("description add response",response);
        })

    }
    handleSizeSave=()=>{
        var data={
            itemId:this.state.itemId,
            size:this.state.itemSize
        }
        addSizes(data).then((response) => {
            console.log("Size add response",response);
        })

    }
    handleColorSave=()=>{
        var data={
            itemId:this.state.itemId,
            color:this.state.itemColor
        }
        addColors(data).then((response) => {
            console.log("Color add response",response);
        })
    }

    render() {
        const Sizes = [
            { value: 'S', label: 'S' },
            { value: 'M', label: 'M' },
            { value: 'L', label: 'L' },
            { value: 'XL', label: 'XL' }
        ]

        let Add;
        let classOpenStatus = this.state.addItemOpen ? "class-none" : "dashboard-card";
        let crop = this.state.itemImage === "" ? "disable" : "";
        if (this.state.updateCard) {
            Add = (
                <div className={classOpenStatus}>
                    <div className="dashboard-container">
                        <div className="add-NewItem">
                            <div className="add-product">
                                Update Item
                        </div>
                            <div className="cancel-button">
                                <img src={require('../Assests/cancel.png')} style={{ height: "30px", width: "30px" }} onClick={this.handleCancel} />
                            </div>
                        </div>
                        <div className="dashboard-inputs font-subHeader">
                            <div className="product-alignment">
                                <div className="product-name"> Product Name:</div>
                                <input type="text" placeholder="Product Name" className="input-text" onChange={this.handleProductName} value={this.state.itemName} />
                            </div>
                            <div className="product-alignment">
                                <input type="text" placeholder="Brand Name" className="input-text" onChange={this.handleBrandName} value={this.state.itemBrandName} />
                            </div>
                        </div>
                        <div className="dashboard-inputs font-subHeader">
                            <div className="product-alignment">
                                <div className="product-price"> Product Price:</div>
                                <input type="number" placeholder="Product Price" className="input-text input-margin" onChange={this.handleProductPrice} value={this.state.price} />
                            </div>
                            <label className="app-label font-subHeader" onChange={this.handleChange}>
                                <input type="file" className="uploadImage" />
                                Upload Image
                            </label>
                        </div>
                        <Cropper className={crop}
                            ref={cropper => { this.cropper = cropper }}
                            src={this.state.Image}
                            style={{ height: "220px", width: "700px" }}
                            aspectRatio={4 / 3}
                            crop={this.handleCrop}
                        />
                        <div className="button">
                            <button onClick={this.handleUpdateApply} className="app-button">Update</button>
                        </div>
                    </div>
                </div>
            )
        }
        var product = this.state.items.map(key => {
            return (
                <div className="product-mainDiv">
                    <div key={key.itemId} className="product-card">
                        <div className="image">
                            <img src={key.itemImage} style={{ height: "215px", width: "100%", borderRadius: "10px", outline: "none" }} />
                        </div>
                        <div className="product-container">
                            <div className="name-price-getProduct">
                                <div className="product-name-getProduct">
                                    {key.itemName}
                                </div>
                                <div className="price">
                                    <div>
                                        ₹
                                    </div>
                                    {key.price}
                                </div>
                            </div>
                            <div className="update-delete-div">
                                <button className="update-delete-button" onClick={() => this.handleUpdateItem(key)}>Update</button>
                                <button className="update-delete-button" onClick={() => this.handleDeleteItem(key.itemId)}>Delete</button>
                            </div>
                            {this.state.updateCard ? null :
                                <div className="select-add">
                                    <Select className="select-admin" id={key.itemId}
                                        options={Sizes}
                                        value={Sizes.value}
                                        placeholder="Size"
                                        isMulti={false}
                                        onChange={(event) => this.handleSizeChange(event, key.itemId)} />
                                    <div>
                                        <button className="update-delete-button" onClick={this.handleSizeSave}>Add</button>
                                    </div>
                                </div>}
                            <div className="select-add">
                                <div className="add-color-input">
                                    <input type="text" placeholder="Color" value={this.state.itemColor} className="color-input" id={key.itemId} onChange={(event) => this.handleColorChange(event, key.itemId)} />
                                </div>
                                <div>
                                    <button className="update-delete-button" onClick={this.handleColorSave}>Add</button>
                                </div>
                            </div>
                            <div className="description">
                                <textarea rows="2" cols="50" className="description-border" name="comment" form="usrform" placeholder="Description1" onChange={this.handleDescription1}></textarea>
                            </div>
                            <div className="description">
                                <textarea rows="2" cols="50" className="description-border" name="comment" form="usrform" placeholder="Description2" onChange={this.handleDescription2}></textarea>
                            </div>
                            <div className="description">
                                <textarea rows="2" cols="50" className="description-border" name="comment" form="usrform" placeholder="Advantage" onChange={this.handleAdvantage}></textarea>
                            </div>
                            <div className="button">
                                <button className="app-viewButton" onClick={()=>this.handleTotalDescription(key.itemId)}>Add Description's</button>
                            </div>
                        </div>
                    </div>
                </div>
            )
        })
        return (
            [Add,
                <div style={{ height: "100%", width: "100%" }}>
                    <DashBoard />
                    <div className="get-getAllProduct ">
                        <div className="product-list">
                            {product}
                        </div>
                    </div>
                </div>]
        )
    }
}