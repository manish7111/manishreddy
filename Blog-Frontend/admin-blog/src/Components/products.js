import React, { Component } from 'react'
import MobileDashboard from './mobileDashboard';
import { getAllItems, getProduct, getAllSizesById, getAllColorsById, AddSelectedItemToCart, getDescriptionById } from '../Controller/services';
import Select from 'react-select';

export default class Product extends Component {
    constructor(props) {
        super(props);
        this.state = {
            items: [],
            status: "",
            itemId: "",
            itemName: "",
            itemImage: "",
            price: "",
            status: "",
            widerView: false,
            description: "",
            description1: "",
            description2: "",
            advantage: "",
            size: [],
            itemSize: "",
            colors: [],
            color: "",
            cart: [],
            email:localStorage.getItem("email")
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
    handleViewButton = (id) => {
        this.setState({
            widerView: true
        })
        getProduct(id).then((response) => {
            if (response) {
                console.log(response);
                this.setState({
                    itemId: response.data.itemId,
                    itemName: response.data.itemName,
                    itemImage: response.data.itemImage,
                    price: response.data.price,
                    status: response.data.status,
                    description: response.data.descriptions
                })
                getAllSizesById(id).then((response) => {
                    response.data.map(key => {
                        this.state.size.push({ label: key.size, value: key.size });
                    });

                    console.log("sizes", this.state.size);
                })
                getAllColorsById(id).then((response) => {
                    response.data.map(key => {
                        this.state.colors.push({ label: key.color, value: key.color });
                    });

                    console.log("colors", this.state.colors);
                })
                getDescriptionById(id).then((response) => {
                    console.log("Description", response);
                    this.setState({
                        description1: response.data.description1,
                        description2: response.data.description2,
                        advantage: response.data.advantage
                    })
                })
            }
        })

    }
    handleBack = () => {
        this.setState({
            widerView: false
        })
    }
    handleSizeChange = async (event) => {
        console.log("event", event.value);
        let item = event.value;
        console.log("item data", item);
        await this.setState({
            itemSize: item
        })
        console.log("itemSize", this.state.itemSize);
    }
    handleColorChange = async (event) => {
        console.log("event", event.value);
        let item = event.value;
        console.log("item data", item);
        await this.setState({
            color: item
        })
        console.log("color", this.state.color);
    }
    handleBuyNow = () => {
        var data = {
            itemId: this.state.itemId,
            itemName: this.state.itemName,
            itemImage: this.state.itemImage,
            price: this.state.price,
            color: this.state.color,
            size: this.state.itemSize,
            numberOfItems: 1,
            status: this.state.status,
            email:this.state.email
        }
        AddSelectedItemToCart(data).then((response) => {
            console.log("response of product added", response)
            if (response) {
                this.props.history.push('/buy');
            }
        });
        console.log("sizes", this.state.size);


    }

    render() {
        let disable = (this.state.itemSize != "" && this.state.color != "") ? "app-viewButton" : "btn-disable"
        let itemView;
        if (this.state.widerView) {
            itemView = (
                <div className="itemView-main">
                    <div className="itemView-card">
                        <div className="image">
                            <img src={this.state.itemImage} className="getAllProduct-getImage" />
                            <div className="icon-top">
                                <img src={require("../Assests/back.png")} style={{ height: "25px", width: "25px" }} onClick={this.handleBack} />
                            </div>
                        </div>
                        <div className="itemView-container">
                            <div className="product-name-container font-header">
                                {this.state.itemName}
                            </div>
                            <div className="itemView-name-price">
                                <div >
                                    <b className="itemView-price" >
                                        <div>
                                            ₹
                                        </div>
                                        {this.state.price}
                                    </b>
                                </div>
                                <div className="status-itemView">
                                    {this.state.status === true ?
                                        <div className="stock">
                                            <img src={require('../Assests/ok.png')} style={{ height: "15px", width: "15px" }} />
                                            <div className="font-stock">In stock</div>
                                        </div> :
                                        <div className="stock">
                                            <img src={require('../Assests/cancel-status.png')} style={{ height: "15px", width: "15px" }} />
                                            <div className="font-stock">Out of stock</div>
                                        </div>}
                                </div>
                            </div>
                            <hr />
                            <div className="description-product">
                                <b style={{ color: "indianred" }}>*</b>
                                <div className="description-detail">
                                    {this.state.description}
                                </div>
                            </div>
                            <div className="select-product">
                                <Select className="select-admin-product"
                                    options={this.state.size}
                                    value={this.state.size.value}
                                    placeholder="Size"
                                    isMulti={false}
                                    onChange={(event) => this.handleSizeChange(event)}
                                    menuPlacement='top' />
                                <Select className="select-admin-product"
                                    options={this.state.colors}
                                    value={this.state.colors.value}
                                    placeholder="Color"
                                    isMulti={false}
                                    onChange={(event) => this.handleColorChange(event)}
                                    menuPlacement='top' />
                            </div>
                            <div className="button-productView">
                                <button className={disable} onClick={this.handleBuyNow} disabled={!this.state.color && !this.state.itemSize}>Buy Now</button>
                            </div>
                            <hr />
                            <div className="productPage-desciption">
                                <div className="description-product">
                                    <b style={{ color: "indianred" }}>*</b>
                                    <div className="description-detail">
                                        {this.state.description1}
                                    </div>
                                </div>
                                <div className="description-product">
                                    <b style={{ color: "indianred" }}>*</b>
                                    <div className="description-detail">
                                        {this.state.description2}
                                    </div>
                                </div>
                                <div className="description-product">
                                    <b style={{ color: "indianred" }}>*</b>
                                    <div className="description-detail">
                                        {this.state.advantage}
                                    </div>
                                </div>
                            </div>
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
                            <img src={key.itemImage} style={{ height: "225px", width: "100%", borderRadius: "10px", outline: "none" }} />
                        </div>
                        <div className="product-container">
                            <div className="product-name-container font-header">
                                {key.itemName}
                            </div>

                            <div className="font-subHeader status">
                                {key.status === true ?
                                    <div className="stock">
                                        <img src={require('../Assests/ok.png')} style={{ height: "15px", width: "15px" }} />
                                        <div className="font-stock">In stock</div>
                                    </div> :
                                    <div className="stock">
                                        <img src={require('../Assests/cancel-status.png')} style={{ height: "15px", width: "15px" }} />
                                        <div className="font-stock">Out of stock</div>
                                    </div>}
                                <div className="name-price">
                                    <div className="price">
                                        <div>
                                            ₹
                                    </div>
                                        {key.price}
                                    </div>
                                </div>
                            </div>
                            <div className="button">
                                <button className="app-viewButton" onClick={() => this.handleViewButton(key.itemId)}>View</button>
                            </div>
                        </div>
                    </div>
                </div>
            )
        })

        return (
            <div className="product-main">
                {/* <MobileDashboard /> */}
                <div className="product-getAllProduct ">
                    {this.state.widerView ? null :
                        <div className="product-page-image">
                            <img src={require('../Assests/club-name.png')} style={{ height: "75px", borderRadius: "20px", cursor: "pointer" }} />
                        </div>}
                    {this.state.widerView ? itemView :
                        <div className="main-div-product">
                            <div className="product-heading">
                                <div className="bad">
                                    <b>Bad Boyz Get Ready</b>
                                </div>
                                <div className="boy">
                                    <b>Drop is On..</b>
                                </div>
                            </div>
                            <div className="product-list">
                                {product}
                            </div>
                        </div>
                    }
                </div>
            </div>

        )
    }
}