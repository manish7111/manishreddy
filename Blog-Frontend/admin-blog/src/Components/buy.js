import React, { Component } from 'react';
import { cartProducts, removeFromCart } from '../Controller/services'
import Spinner from './spinner';

export default class Buy extends Component {
    constructor(props) {
        super(props);
        this.state = {
            numberOfItems: 0,
            cart: [],
            totalPrice: 0,
            spinner:false,
            email:localStorage.getItem("email")
        }
    }
    componentDidMount() {
        this.getAllProductsInCart();
    }
    getAllProductsInCart = () => {
           cartProducts(this.state.email).then((response) => {
            this.setState({
                cart: response.data,
                spinner:true
            })
            console.log("list of items", this.state.cart);
        })
    }
    handleBack = () => {
        this.props.history.push('/product');
    }
    handlePlusItems = (event, id) => {
        event.preventDefault();
        this.setState({
            numberOfItems: this.state.numberOfItems + 1
        })
    }
    handleMinusItems = (event, id) => {
        if (event.target.id == id)
            if (this.state.numberOfItems > 0)
                this.setState({
                    numberOfItems: this.state.numberOfItems - 1
                })
            else {
                this.setState({
                    numberOfItems: 0
                })
            }
    }
    handleRemove = (id) => {
        console.log(id);
        removeFromCart(id).then((response) => {
            console.log("removed", response);
            if (response) {
                window.location.reload();
            }
        })

    }
    handleCheckOut=()=>{
        this.props.history.push('/address');
    }

    render() {
        var Cart =
            this.state.cart.map((key) => {
                console.log(key.numberOfItems);
                this.state.numberOfItems += key.numberOfItems;
                this.state.totalPrice += (key.numberOfItems * key.price);
                localStorage.setItem("price",this.state.totalPrice);
                return (
                    <div className="buy-container-border">
                        <div className="buy-container">
                            <div>
                                <div className="buy-name">
                                    {key.itemName}
                                </div>
                                <div className="buy-status">
                                    {key.status ? <div className="stock">
                                        <img src={require('../Assests/ok.png')} style={{ height: "15px", width: "15px" }} />
                                        <div className="font-stock">In stock</div>
                                    </div> :
                                        <div className="stock">
                                            <img src={require('../Assests/cancel-status.png')} style={{ height: "15px", width: "15px" }} />
                                            <div className="font-stock">Out of stock</div>
                                        </div>}
                                </div>
                                <div className="buy-price">
                                    <div> ₹</div>
                                    {key.price}
                                </div>
                                <div className="buy-icons">
                                    <div className="buy-more">
                                        <img id={key.id} src={require('../Assests/more.png')} style={{ height: "18px", width: "18px" }} onClick={(event) => this.handlePlusItems(event, key.id)} />
                                    </div>
                                    <div className="buy-number">
                                        {key.numberOfItems}
                                    </div>
                                    <div className="buy-minus">
                                        <img id={key.itemId} src={require('../Assests/minus.png')} style={{ height: "18px", width: "18px" }} onClick={(event) => this.handleMinusItems(event, key.id)} />
                                    </div>
                                </div>
                            </div>
                            <div className="buy-image">
                                <img src={key.itemImage} style={{ height: "85px", width: "100px" }} />
                            </div>
                        </div>
                        <div className="buy-size-color">
                            <div className="buy-size">
                                <b className="buy-alignment">Size</b>
                                <div className="buy-color">
                                    {key.size}
                                </div>
                            </div>
                            <div className="buy-size">
                                <b className="buy-alignment">Color</b>
                                <div className="buy-color">
                                    {key.color}
                                </div>
                            </div>
                        </div>
                        <hr />
                        <div className="buy-remove" onClick={() => this.handleRemove(key.id)}>
                            {/* <button className="Remove-cart-button" >Remove From Cart</button> */}
                            Remove From Cart
                        </div>
                        <hr />
                    </div>
                )
            })
            let Spin;
            if (this.state.spinner) {
                Spin = (
                    <div className="spinner-card">
                        <Spinner />
                    </div>
                )
            }
        return (
            <div className="buy-main">
                <div className="buy-main-below">
                    <div className="buy-title">
                        <img src={require('../Assests/club-name.png')} style={{ width: "240px", height: "55px", borderRadius: "10px" }} />
                        <div className="icon-top-buy">
                            <img src={require("../Assests/back.png")} style={{ height: "25px", width: "25px" }} onClick={this.handleBack} />
                        </div>
                    </div>
                    {this.state.spinner?
                        this.state.cart == "" ?
                        <div className="buy-container-null">
                            No items added to cart.
                    </div>
                        :
                        <div className="cart-products">
                            {Cart}
                        </div>:Spin}
                </div>
                {this.state.cart == "" ? null :
                    <div className="buy-below-container">
                        <div className="buy-below-remove">
                            <div className="buy-number-selected">
                                <div>Number of items selected :</div>
                                <div>{this.state.numberOfItems}</div>
                            </div>
                            <div className="buy-number-selected">
                                <div>Total Price :</div>
                                <div className="buy-priceView">
                                    <div>₹</div>
                                    <div>{this.state.totalPrice}</div>
                                </div>
                            </div>
                            <div className="checkout-button">
                                <button className="Remove-cart-button" onClick={this.handleCheckOut}>Check Out</button>
                            </div>
                        </div>
                    </div>}
            </div>
        )
    }
}