import React, { Component } from 'react'
import { TextField, Card,Button } from '@material-ui/core'
import {userResetPassword} from '../Services/userServices.js'
export default class ResetPasswordComponent extends Component {
    constructor(props) {
        super(props)
        this.state = {
            Email:"",
            Password:""
        }
    }
    //handleChangeEmail is used to change the email when required.
    handleChangeEmail = (event) => {
        const Email = event.target.value
        this.setState({
            Email: Email
        })
        console.log("reset email",this.state.Email);
        
    }
    handleChangePassword = (event) => {
        const Password = event.target.value
        this.setState({
            Password: Password
        })
        console.log("reset password",this.state.Password);

    }
    handleForgetPassword=(event)=>{
        event.preventDefault();
        if (this.state.Email === "") {
            this.setState({
                openSnackBar: true,
                snackBarMessage: "Email cannot be empty..!"
            });
        }else if (this.state.Password === ""){
            this.setState({
                openSnackBar: true,
                snackBarMessage: "Password cannot be empty..!"
            });
        }else
        {
            var data = {
                Email: this.state.Email,
                Password:this.state.Password
              
            }
            userResetPassword(data)
                .then((response) => {
                    console.log("login response====>", response);

                    this.setState({
                        openSnackBar: true,
                        snackBarMessage: "SignIn Successfully!!"
                    });
                    this.props.props.history.push("/login");

                })
                .catch((err) => {
                    console.log("error in user login----------", err);
                    this.setState({
                        openSnackBar: true,
                        snackBarMessage: "Incorrect Email !!"
                    });
                });
        }
    };
    render() {
        return (
            <div>
                <form className='forgetPassword'>
                    <Card className='forgetCard'>
                        <div style={{ marginLeft: "68px" }}>
                            <b>
                                <h4>
                                    <span style={{ color: "Red" }}>Reset Password</span>
                                </h4>
                            </b>
                        </div>
                        <div className='forgetFeilds'>
                            <TextField
                                id="outlined-Email-input"
                                label="Enter Correct Email*"
                                type="Email"
                                name="Email"
                                autoComplete="Email"
                                margin="normal"
                                variant="outlined"
                                onChange={this.handleChangeEmail}
                                value={this.state.Email}
                            />
                        </div>
                        <div className='forgetFeilds'>
                        <TextField
                            id="outlined-Password-input"
                            label="Enter Correct Password*"
                            type="Password"
                            name="Password"
                            autoComplete="Password"
                            margin="normal"
                            variant="outlined"
                            onChange={this.handleChangePassword}
                            value={this.state.Password}
                        />
                    </div>
                        <div className='submitForget'>
                            <Button variant="contained" color="primary" onClick={this.handleForgetPassword} >
                                Submit
                        </Button>
                        </div>
                    </Card>
                </form>
            </div>
        )
    }
}