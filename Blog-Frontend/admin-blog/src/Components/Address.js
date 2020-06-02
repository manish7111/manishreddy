import React, { Component } from 'react';
import { addAddress,getAddress } from '../Controller/services';
export default class Address extends Component {
    constructor(props) {
        super(props);
        this.state = {
            changeAddress: false,
            totalPrice: localStorage.getItem("price"),
            shippingCost: 25,
            firstName: "",
            lastName: "",
            email: localStorage.getItem("email"),
            flatOrHouseNo: "",
            streetOrLocality: "",
            city: "",
            state: "",
            zipCode: ""
        }
    }
    componentDidMount=()=>{
        getAddress(this.state.email).then((response) => {
            console.log(response,"comming")
        })
    }
    handleFirstName = (event) => {
        this.setState({
            firstName: event.target.value
        })
    }
    handleLastName = (event) => {
        this.setState({
            lastName: event.target.value
        })
    }
    handleHouseNo = (event) => {
        this.setState({
            flatOrHouseNo: event.target.value
        })
    }
    handleLocality = (event) => {
        this.setState({
            streetOrLocality: event.target.value
        })
    }
    handleCity = (event) => {
        this.setState({
            city: event.target.value
        })
    }
    handleState = (event) => {
        this.setState({
            state: event.target.value
        })
    }
    handleZipCode = (event) => {
        this.setState({
            zipCode: event.target.value
        })
    }

    handleBack = () => {
        this.props.history.push('/buy');
    }
    handleChange = () => {
        this.setState({
            changeAddress: true
        })
    }
    handleSave = async () => {
        var data = {
            firstName: this.state.firstName,
            lastName: this.state.lastName,
            email: localStorage.getItem("email"),
            flatOrHouseNo: this.state.flatOrHouseNo,
            streetOrLocality: this.state.streetOrLocality,
            city: this.state.city,
            state: this.state.state,
            zipCode: this.state.zipCode
        }
        await addAddress(data).then((response) => {
            if (response) {
                console.log("address response", response);
                this.setState({
                    changeAddress: false
                })
            } else {
                console.log("Add Address failed");
                this.setState({
                    changeAddress: true
                })
            }
        })
    }

    render() {
        let totalPrice = parseInt(this.state.totalPrice);
        let shippingCost = parseInt(this.state.shippingCost);
        let totalGST = parseInt(0.18 * totalPrice);
        let TotalCostWithGst = totalPrice + totalGST + shippingCost;
        console.log("total cost", TotalCostWithGst)
        return (
            <div className="buy-main" >
                <div className="Address-main-below">
                    <div className="buy-title">
                        <img src={require('../Assests/club-name.png')} style={{ width: "240px", height: "55px", borderRadius: "10px" }} />
                        <div className="icon-top-buy">
                            <img src={require("../Assests/back.png")} style={{ height: "25px", width: "25px" }} onClick={this.handleBack} />
                        </div>
                    </div>
                </div>
                {this.state.changeAddress ?
                    <div className="address-container-saving">
                        <div className="address-container-input">
                            <input className="address-input" placeholder="First Name" onChange={this.handleFirstName} />
                        </div>
                        <div className="address-container-input">
                            <input className="address-input" placeholder="Last Name" onChange={this.handleLastName} />
                        </div>
                        <div className="address-container-input">
                            <input className="address-input" placeholder={this.state.email} />
                        </div>
                        <div className="address-container-input">
                            <input className="address-input" placeholder="Flat / House No." onChange={this.handleHouseNo} />
                        </div>
                        <div className="address-container-input">
                            <input className="address-input" placeholder="Street / Locality" onChange={this.handleLocality} />
                        </div>
                        <div className="address-container-input">
                            <input className="address-input" placeholder="City" onChange={this.handleCity} />
                        </div>
                        <div className="address-container-input">
                            <input className="address-input" placeholder="State" onChange={this.handleState} />
                        </div>
                        <div className="address-container-input">
                            <input className="address-input" placeholder="ZipCode" onChange={this.handleZipCode} />
                        </div>
                        <div className="Proceed-To-pay">
                            <button className="Remove-cart-button" onClick={this.handleSave}>Save & Proceed</button>
                        </div>
                    </div> :
                    <div className="address-container">
                        <div className="shipping-address">
                            <b>Shipping Address :</b>
                        </div>
                        <div className="address-number">
                            <div className="address">
                                Address:
                        </div>
                            <div className="address-card">
                                {this.state.flatOrHouseNo},{this.state.streetOrLocality},{this.state.city},{this.state.state},{this.state.zipCode}
                            </div>
                        </div>
                        <div className="address-number">
                            <div className="address">
                                Phone Number:
                        </div>
                            <div className="address-card">
                                7760467611
                        </div>
                        </div>
                        <div className="address-change">
                            <button className="Remove-cart-button" onClick={this.handleChange}>Change Address</button>
                        </div>
                    </div>
                }
                {
                    this.state.changeAddress ? null :
                        <div className="Proceed-payment">
                            <div className="payment-total">
                                <div className="payment-alignment">
                                    <div>Sub Total</div>
                                    <div>:</div>
                                </div>
                                <div className="gst-div">
                                    <div>₹</div>
                                    <div>{this.state.totalPrice}</div>
                                </div>
                            </div>
                            <div className="payment-total">
                                <div className="payment-alignment">
                                    <div>Shipping</div>
                                    <div>:</div>
                                </div>
                                <div className="gst-div">
                                    <div>₹</div>
                                    <div>{this.state.shippingCost}</div>
                                </div>
                            </div>
                            <div className="payment-total">
                                <div className="payment-alignment">
                                    <div>GST</div>
                                    <div>:</div>
                                </div>
                                <div className="gst-div">
                                    <div>₹</div>
                                    <div>{totalGST}</div>
                                </div>
                            </div>
                            <div className="payment-total">
                                <div className="payment-alignment">
                                    <div>Total</div>
                                    <div>:</div>
                                </div>
                                <div className="gst-div">
                                    <div>₹</div>
                                    <div>{TotalCostWithGst}</div>
                                </div>
                            </div>
                            <div className="Proceed-To-pay">
                                <button className="Remove-cart-button">Proceed To Pay</button>
                            </div>
                        </div>
                }
            </div >
        )
    }
}