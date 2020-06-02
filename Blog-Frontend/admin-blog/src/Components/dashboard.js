import React, { Component } from 'react';
import { withRouter } from 'react-router-dom';
import Cropper from 'react-cropper';
import 'cropperjs/dist/cropper.css'
import { addProduct } from '../Controller/services';
import Spinner from './spinner';

class Dashboard extends Component {
    constructor(props) {
        super(props);
        this.state = {
            card: false,
            Image: "",
            itemName: "",
            description: "",
            itemImage: null,
            price: "",
            open: false,
            addItemOpen: false,
            spinner: false,
            quantity:""
        }
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
    handleAddProduct = () => {
        this.setState({
            card: true,
            open: false
        })
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
    handleDescription = (event) => {
        let data = event.target.value;
        this.setState({
            description: data
        })
    }
    handleProductPrice = (event) => {
        let data = event.target.value;
        this.setState({
            price: data
        })
    }
    handleChangeQuantity=(event)=>{
        let data = event.target.value;
        this.setState({
            quantity: data
        })
    }
    handleApplyButtonClick = () => {
        this.setState({
            spinner: true
        })
        var data = {
            itemName: this.state.itemName,
            descriptions: this.state.description,
            price: this.state.price,
            itemImage: this.state.itemImage,
            quantity:this.state.quantity
        }
        console.log("data", data)
        addProduct(data).then((response) => {
            this.setState({
                addItemOpen: true,
                spinner: false
            })
            console.log("Add new Product response====>", response);
            window.location.reload();
        })
            .catch((err) => {
                console.log("error occured while adding----------", err);
            });
    }
    handleMenuClick = () => {
        if (!this.state.open) {
            this.setState({
                open: true
            })
        }
        else {
            this.setState({
                open: false
            })
        }

    }
    handleCancel = () => {
        this.setState({
            card: false
        })
    }

    render() {
        let Add, spinner;
        let crop = this.state.Image === "" ? "disable" : "";
        let classStatus = this.state.open ? "dashboard-sideDrawer" : "class-none"
        let classOpenStatus = this.state.addItemOpen ? "class-none" : "dashboard-card"
        Add = (
            <div className={classOpenStatus}>
                <div className="dashboard-container">
                    <div className="add-NewItem">
                        <div className="add-product">
                            Add New Item
                        </div>
                        <div className="cancel-button">
                            <img src={require('../Assests/cancel.png')} style={{ height: "30px", width: "30px" }} onClick={this.handleCancel} />
                        </div>
                    </div>
                    <div className="dashboard-inputs font-subHeader">
                        <input type="text" placeholder="Product Name" className="input-text" onChange={this.handleProductName} />
                        <input type="number" placeholder="Product Price" className="input-text" onChange={this.handleProductPrice} />
                    </div>
                    <div className="dashboard-inputs font-subHeader">
                    <input type="number" placeholder="Quantity" className="input-text" onChange={this.handleChangeQuantity} />
                        <label className="app-label font-subHeader" onChange={this.handleChange}>
                            <input type="file" className="uploadImage" />
                            Upload Image
                            </label>
                    </div>
                    <Cropper className={crop}
                        ref={cropper => { this.cropper = cropper }}
                        src={this.state.Image}
                        style={{ height: "200px", width: "700px" }}
                        aspectRatio={4 / 3}
                        crop={this.handleCrop}
                    />
                    <div className="description">
                        <textarea rows="4" cols="50" className="description-border" name="comment" form="usrform" placeholder="Description" onChange={this.handleDescription}></textarea>
                    </div>
                    <div className="button">
                        <button onClick={this.handleApplyButtonClick} className="app-button">Apply</button>

                    </div>
                </div>
            </div>
        )
        if (this.state.spinner) {
            spinner = (
                <div className="dashboard-card">
                    <Spinner />
                </div>
            )
        }

        return (
            [spinner,
                <div className="dashboard-main-div">
                    <div className="dashboard-main font-header">
                        <div className="dashboard-page-image">
                            <img src={require('../Assests/club-name.png')} style={{ height: "75px", borderRadius: "20px", cursor: "pointer" }} />
                        </div>
                        <div className="icon-top-dashboard">
                        <img src={require('../Assests/menu.png')} style={{ height: "15px", width: "20px", cursor: "pointer" }} onClick={this.handleMenuClick} />
                    </div>
                    </div>
                    
                    <div className={classStatus}>
                        <div className="dashboard-sideNav-items">
                            <img src={require("../Assests/label.png")} style={{ width: "25px", height: "15px", paddingRight: "12px", paddingTop: "5px" }} />
                            <div className="sideNav-items" onClick={this.handleAddProduct}>
                                Add New Item
                        </div>
                        </div>
                    </div>
                    {this.state.card ? Add : null}
                </div>
            ])
    }
}
export default withRouter(Dashboard);