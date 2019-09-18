/*****************************************************************************************************
 *  @Purpose        : Here we have to create the LoginComponent that contains all required LoginComponent components.
 *  @file           : LoginComponent.jsx       
 *  @author         : Manish Reddy
 *  @version        : v0.1
 *  @since          : 12-09-2019
 *****************************************************************************************************/
import React from 'react';
import TextField from '@material-ui/core/TextField';
import Button from '@material-ui/core/Button';
import { Card } from '@material-ui/core';
import { userSignIn, userFbSignIn } from '../Services/userServices.js';
import Snackbar from '@material-ui/core/Snackbar';
import FacebookLogin from 'react-facebook-login';
import GoogleLogin from 'react-google-login';

//LoginComponent is a class which extends React class.
export default class LoginComponent extends React.Component {
    constructor(props) {
        super(props)
        this.state = {
            Email: "",
            Password: ""
        }
    }

    //handleChangeEmail is used to change the state of email whenever required.
    handleChangeEmail = (event) => {
        const Email = event.target.value
        this.setState({
            Email: Email
        })
    }
     //handleChangePassword is used to change the state of Password whenever required.
    handleChangePassword = (event) => {
        const Password = event.target.value
        this.setState({
            Password: Password
        })
    }
     //handleRegister is a button used to register the users and redirect to login page.
    handleRegister = () => {
        this.props.props.history.push('/register')
    }
    //handleForget is used to get the new password according to the email address provided. 
    handleForget = () => {
        this.props.props.history.push('/forget')
    }
    componentClicked = () => {
        console.log("clicked");

    }



    //getting the responce from the facebook login.
    responseFacebook = (response) => {
        console.log(response)
        this.setState({
            Email: response.email
        })
        var data = {
            Email: this.state.Email
        }
        localStorage.setItem('myData', this.state.Email);
        localStorage.getItem('myData');
        console.log("-----------", data.Email);

        userFbSignIn(data)
            .then((response) => {
                console.log("login response====>", response);
                this.setState({
                    openSnackBar: true,
                    snackBarMessage: "SignIn Successfully!!"
                });
                this.props.props.history.push("/dashboard");

            })
            .catch((err) => {
                console.log("error in user login----------", err);

            });
    }

    //its an event button used to handle the signin.
    handleSignIn = (event) => {
        event.preventDefault();
        if (this.state.Email === "") {
            this.setState({
                openSnackBar: true,
                snackBarMessage: "Email cannot be empty..!"
            });

        } else if (this.state.Password === "") {
            this.setState({
                openSnackBar: true,
                snackBarMessage: "Password cannot be empty..!"
            });
        } else {
            var data = {
                Email: this.state.Email,
                Password: this.state.Password
            }
            localStorage.setItem('myData', this.state.Email);
            localStorage.getItem('myData');
            userSignIn(data)
                .then((response) => {
                    console.log("login response====>", response);

                    this.setState({
                        openSnackBar: true,
                        snackBarMessage: "SignIn Successfully!!"
                    });
                    this.props.props.history.push("/dashboard");

                })
                .catch((err) => {
                    console.log("error in user login----------", err);
                    this.setState({
                        openSnackBar: true,
                        snackBarMessage: "Incorrect Email or Password!!"
                    });
                });
        }
    };

    //getting the response from the google signin.
    responseGoogle = (response) => {
        console.log("detals of login", response.w3.U3);

        this.setState({
            Email: response.w3.U3
        })
        var data = {
            Email: this.state.Email
        }

        //for setting and getting the localstorage data.
        localStorage.setItem('myData', this.state.Email);
        localStorage.getItem('myData');
        CacheStorage.open();
        console.log("-----------", data.Email);

        //userFbSignIn is a service call data.
        userFbSignIn(data)
            .then((response) => {

                console.log("login response====>", response);
                this.setState({
                    openSnackBar: true,
                    snackBarMessage: "SignIn Successfully!!"
                });
                this.props.props.history.push("/dashboard");

            })
            .catch((err) => {
                console.log("error in user login----------", err);

            });

    }

    //callbackResponse is a responce from server.
    callbackResponse = (res) => {
        console.log("callback response ==>" + res);
    }

    //render is used to handle the application.
    render() {
        return (
            <div>
                <form className="login">
                    <Card className='loginCard'>
                        <div className='adjust'>
                            <div className='font' style={{ marginLeft: "155px" }}>
                                <b >
                                    <h4>
                                        <span style={{ color: "blue" }}>F</span>
                                        <span style={{ color: "Red" }}>u</span>
                                        <span style={{ color: "Yellow" }}>n</span>
                                        <span style={{ color: "blue" }}>d</span>
                                        <span style={{ color: "Green" }}>o</span>
                                        <span style={{ color: "Red" }}>o</span>
                                    </h4>
                                </b>
                            </div>
                            <div style={{ marginLeft: "170px" }}>
                                <b>
                                    SignIn
                            </b>
                            </div>
                            <div style={{ marginLeft: "115px" }}>Use Your Google Account</div>
                            <div className='inputField'>
                                <TextField required
                                    id="outlined-email-input"
                                    label="Email"
                                    type="email"
                                    name="email"
                                    autoComplete="email"
                                    margin="normal"
                                    variant="outlined"
                                    onChange={this.handleChangeEmail}
                                    value={this.state.Email}
                                />
                            </div>
                            <div className='inputField'>
                                <TextField required
                                    id="outlined-password-input"
                                    label="Password"
                                    type="password"
                                    autoComplete="current-password"
                                    margin="normal"
                                    variant="outlined"
                                    onChange={this.handleChangePassword}
                                    value={this.state.Password}
                                />
                            </div>
                            <div className='button'>
                                <Button variant="contained" color="secondary" onClick={this.handleSignIn}>
                                    SignIn
                            </Button>
                                <Button variant="contained" color="primary" onClick={this.handleRegister}>
                                    SignUp
                            </Button>
                            </div>
                            <div className='butt'>
                                <Button color="primary" onClick={this.handleForget}>
                                    Forgot
                                    Password
                            </Button>
                            </div>
                            <div className='google'>
                                <GoogleLogin
                                    clientId="768275105166-ak5hnnsd2ldfdr2orpoi00pcoasi86h8.apps.googleusercontent.com"
                                    buttonText="LOGIN WITH GOOGLE"
                                    onSuccess={this.responseGoogle}
                                    onFailure={this.responseGoogle}
                                    cookiePolicy={'single_host_origin'}
                                    callback={this.callbackResponse}
                                /></div>
                            <div className='fb'><FacebookLogin
                                appId="536509143751633"
                                fields="email"
                                onClick={this.componentClicked}
                                cookiePolicy={'single_host_origin'}
                                callback={this.responseFacebook}
                                icon="fa-facebook"
                            /></div>

                        </div>
                    </Card>
                </form>
                <Snackbar
                    anchorOrigin={{
                        vertical: 'bottom',
                        horizontal: 'left',
                    }}
                    open={this.state.openSnackBar}
                    autoHideDuration={6000}
                    onClose={this.handleSnackClose}
                    variant="error"
                    ContentProps={{
                        'aria-describedby': 'message-id',
                    }}
                    message={<span id="message-id"> {this.state.snackBarMessage} </span>}
                    action={[
                        <div key="undo">
                            <Button key="undo" color="primary" size="small" onClick={this.handleSnackClose}>
                                UNDO
                        </Button>
                        </div>
                    ]}
                />
            </div>
        )
    }
}
