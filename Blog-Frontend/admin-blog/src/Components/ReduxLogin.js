import React, { Component } from 'react';
//import { login, VerifyOTP } from '../Controller/services.js';
import { connect } from 'react-redux';
import { loginUser, VerifyOtp } from "../Action/UserActions";
import Spinner from './spinner';
class ReduxLogin extends Component {
    constructor(props) {
        super(props);
        this.state = {
            email: "",
            spinner: false,
            requestError: false,
            verifyError: false,
            requestOTP: true,
            OTP: ""
        }
    }
    componentWillReceiveProps(nextProps) {
        console.log("next", nextProps)
        if (nextProps.otp.status === 200) {
            this.setState({
                spinner: false,
                requestOTP: false
            })
        }
        else {
            console.log("otp request failed");
            this.setState({
                spinner: false,
                requestError: true
            })
        }
        if (nextProps.verifyOtp.status === 200) {
            this.setState({
                spinner: false
            })
            localStorage.setItem("email", this.state.email);
            this.props.history.push('/product');
        }
        else {
            console.log("otp request failed");
            this.setState({
                spinner: false,
                verifyError: true
            })
        }
    }
    handleEmailChange = async (event) => {
        var email = event.target.value;
        await this.setState({
            email: email
        })
    }

    handleRequestOTP = async () => {
        this.setState({
            spinner: true
        })
        var data = {
            email: this.state.email
        }

        this.props.loginUser(data.email)
    }
    handleOTPChange = (event) => {
        var otp = event.target.value;
        this.setState({
            OTP: otp
        })
    }
    handleVerifyOTP = async () => {
        this.setState({
            spinner: true
        })
        var data = {
            email: this.state.email,
            otp: this.state.OTP
        }
        this.props.VerifyOtp(data);
    }
    handleTwitterClick = () => {

    }
    handlelinkedinClick = () => {

    }
    handleFacebookClick = () => {

    }
    handleInstagramClick = () => {
        window.location.href = "https://www.instagram.com/_manishreddy/"
    }
    render() {
        let Spin;
        let disable = (this.state.email != "") ? "Remove-cart-button" : "btn-disable";
        let OTPdisable = (this.state.OTP != "") ? "Remove-cart-button" : "btn-disable";
        if (this.state.spinner) {
            Spin = (
                <div className="spinner-card">
                    <Spinner />
                </div>
            )
        }
        return (
            [Spin,
                <div className="buy-main">
                    <div className="buy-title">
                        <img src={require('../Assests/club-name.png')} style={{ width: "240px", height: "55px", borderRadius: "10px" }} />
                    </div>
                    {this.state.requestOTP ?
                        <div className="login-container-div">
                            <div className="login-container">
                                <input className="address-input" type="email" placeholder="Email" onChange={this.handleEmailChange} />
                                <div className="Proceed-To-pay">
                                    <button className={disable} onClick={this.handleRequestOTP}>Request OTP</button>
                                </div>
                                <div className="icons-loginPage">
                                    <img src={require("../Assests/jacket.png")} className="loginPage-icon-images" />
                                    <img src={require("../Assests/hoodie.png")} className="loginPage-icon-images" />
                                    <img src={require("../Assests/phant.png")} className="loginPage-icon-images" />
                                    <img src={require("../Assests/shoe.png")} className="loginPage-icon-images" />
                                </div>
                                <div className="Login-description-1">
                                    * Own the Streets With the Look..
                            </div>
                            </div>
                            <div className="Login-DownNav">
                                <div className="loginPage-FollowUs">Follow Us On </div>
                                <img src={require("../Assests/twitter.png")} className="loginPage-SocialIcon-images" onClick={this.handleTwitterClick} />
                                <img src={require("../Assests/linkedin.png")} className="loginPage-SocialIcon-images" onClick={this.handlelinkedinClick} />
                                <img src={require("../Assests/facebook.png")} className="loginPage-SocialIcon-images" onClick={this.handleFacebookClick} />
                                <img src={require("../Assests/instagram.png")} className="loginPage-SocialIcon-images" onClick={this.handleInstagramClick} />
                            </div>
                        </div> :
                        <div className="login-container-div">
                            <div className="login-container">
                                <input className="address-input" type="number" placeholder="Enter OTP" onChange={this.handleOTPChange} />
                                <div className="Proceed-To-pay">
                                    <button className={OTPdisable} onClick={this.handleVerifyOTP}>Verify OTP</button>
                                </div>
                                <div className="icons-loginPage">
                                    <img src={require("../Assests/jacket.png")} className="loginPage-icon-images" />
                                    <img src={require("../Assests/hoodie.png")} className="loginPage-icon-images" />
                                    <img src={require("../Assests/phant.png")} className="loginPage-icon-images" />
                                    <img src={require("../Assests/shoe.png")} className="loginPage-icon-images" />
                                </div>
                                <div className="Login-description-2">
                                    * You are one step closer to checkout the Stock..
                            </div>
                            </div>
                            <div className="Login-DownNav">
                                <div className="loginPage-FollowUs">Follow Us On </div>
                                <img src={require("../Assests/twitter.png")} className="loginPage-SocialIcon-images" />
                                <img src={require("../Assests/linkedin.png")} className="loginPage-SocialIcon-images" />
                                <img src={require("../Assests/facebook.png")} className="loginPage-SocialIcon-images" />
                                <img src={require("../Assests/instagram.png")} className="loginPage-SocialIcon-images" />
                            </div>
                        </div>}
                </div>]
        )
    }
}

const mapStateToProps = (state) => ({
    otp: state.user.otp,
    verifyOtp: state.user.verifyOtp
})
export default connect(
    mapStateToProps, { loginUser, VerifyOtp }
)(ReduxLogin);