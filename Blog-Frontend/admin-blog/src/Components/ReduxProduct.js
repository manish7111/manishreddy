import React, { Component } from 'react'
//import MobileDashboard from './mobileDashboard';
//import { getAllItems, getProduct, getAllSizesById, getAllColorsById, AddSelectedItemToCart, getDescriptionById } from '../Controller/services';
import Select from 'react-select';
import { GetAllItems, GetItemById, GetAllItemSizes, GetAllItemColors, GetAllItemDescriptions } from '../Action/UserActions';
import { connect } from 'react-redux';
import { All_PRODUCTS } from '../Action/Types';
import { getAllItems } from '../Controller/services';


const mapStateToProps = (state) => ({
    allProducts: state.user.allProducts,
    productById: state.user.productById,
    sizes: state.user.sizes,
    colors: state.user.colors,
    descriptions: state.user.descriptions,
    addedItemsToCart: state.user.addedItemsToCart
})
const mapDispatchToProps=dispatch=>({
    GetAllItems:(items)=>
        dispatch({type:All_PRODUCTS,payload:items})
    
})

class ReduxProduct extends Component {
    constructor(props) {
        super(props);
        this.state = {
            items: this.props.allProducts.data,
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
            email: localStorage.getItem("email")
        }
    }
    // componentWillReceiveProps(nextProps) {
    //     if (nextProps.allProducts.status === 200) {
    //         this.setState({
    //             items: nextProps.allProducts.data
    //         })
    //         console.log("list of items", this.state.items);
    //     }
    //     else {
    //         console.log("error in list of items");
    //     }
    //     if (nextProps.productById.status === 200) {
    //         this.setState({
    //             itemId: nextProps.productById.data.itemId,
    //             itemName: nextProps.productById.data.itemName,
    //             itemImage: nextProps.productById.data.itemImage,
    //             price: nextProps.productById.data.price,
    //             status: nextProps.productById.data.status,
    //             description: nextProps.productById.data.descriptions
    //         })
    //     }
    //     if (nextProps.sizes.status === 200) {
    //         console.log("added sizes");
    //         console.log(nextProps.sizes.data,"saassa");
    //         nextProps.sizes.data.map(key => {
    //             this.state.size.push({ label: key.size, value: key.size });
    //         });
    //     }

    //     if (nextProps.colors.status === 200) {
    //         console.log("added colors")
    //         nextProps.colors.data.map(key => {
    //             this.state.colors.push({ label: key.color, value: key.color });
    //         });
    //     }

    //     if (nextProps.descriptions.status === 200) {
    //         console.log("added des")
    //         this.setState({
    //             description1: nextProps.descriptions.data.description1,
    //             description2: nextProps.descriptions.data.description2,
    //             advantage: nextProps.descriptions.data.advantage
    //         })
    //     }

    //     if (nextProps.addedItemsToCart.status === 200) {
    //         this.props.history.push('/buy');
    //     }
    // }
    componentDidMount() {
        //this.getAllProducts();
        // this.props.allProducts.data.map(key => {
        //     console.log("key",key);
        //     this.state.items.push({ label: key.size, value: key.size });
        // });

        getAllItems().then(response=>{
            console.log("sajk.sadksda0",this.state.items);
            this.props.GetAllItems(response);
        })
    }
    // getAllProducts = () => {
    //     getAllItems().then(response=>{
    //         console.log("sajk.sadksda0",response);
    //         this.props.GetAllItems(response);
    //     })
    // }
    handleViewButton = async (id) => {
        this.setState({
            widerView: true
        })
        await this.props.GetItemById(id);
        await this.props.GetAllItemSizes(id);
        await this.props.GetAllItemColors(id);
        await this.props.GetAllItemDescriptions(id);
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
            email: this.state.email
        }
        this.props.AddSelectedItemToCart(data);
    }

    render() {
        console.log(this.props.allProducts.data,"-----------------------------");
        console.log("sajk.sadksda1",this.state.items);
       
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
export default connect(mapStateToProps, mapDispatchToProps)(ReduxProduct);