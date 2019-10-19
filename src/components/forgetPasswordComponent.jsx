/*****************************************************************************************************
 *  @Purpose        : Here we have to create the ForgetPasswordComponent that contains all required ForgetPasswordComponent components.
 *  @file           : ForgetPasswordComponent.jsx       
 *  @author         : Manish Reddy
 *  @version        : v0.1
 *  @since          : 12-09-2019
 *****************************************************************************************************/

import React, { Component } from 'react'
import { TextField, Card,Button } from '@material-ui/core'
import {userForgetPassword} from '../services/userServices'
//ForgetPasswordComponent is a component class which implememnts component
export default class ForgetPasswordComponent extends Component {
    constructor(props) {
        super(props)
        this.state = {
            Email:""
            
        }
    }
    //handleChangeEmail is used to change the email when required.
    handleChangeEmail = (event) => {
        const email = event.target.value
        this.setState({
            Email: email
        })
    }
    
   
    handleForgetPassword=(event)=>{
        event.preventDefault();
        if (this.state.Email === "") {
            this.setState({
                openSnackBar: true,
                snackBarMessage: "Email cannot be empty..!"
            });

        }else
        {
            var data = {
                Email: this.state.Email
              
            }
            userForgetPassword(data)
                .then((response) => {
                    console.log("login response====>", response);

                    this.setState({
                        openSnackBar: true,
                        snackBarMessage: "SignIn Successfully!!"
                    });
                    this.props.props.history.push("/reset");

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
        
    
   //rendor is a function.
    render() {
        return (
            <div>
                <form className='forgetPassword'>
                    <Card className='forgetCard'>
                        <div style={{ marginLeft: "88px" }}>
                            <b>
                                <h4>
                                    <span style={{ color: "Red" }}>Forget Password</span>
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
