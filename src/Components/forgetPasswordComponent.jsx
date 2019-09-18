/*****************************************************************************************************
 *  @Purpose        : Here we have to create the ForgetPasswordComponent that contains all required ForgetPasswordComponent components.
 *  @file           : ForgetPasswordComponent.jsx       
 *  @author         : Manish Reddy
 *  @version        : v0.1
 *  @since          : 12-09-2019
 *****************************************************************************************************/

import React, { Component } from 'react'
import { TextField, Card,Button } from '@material-ui/core'

//ForgetPasswordComponent is a component class which implememnts component
export default class ForgetPasswordComponent extends Component {
    constructor(props) {
        super(props)
        this.state = {
            Email:"",
            Password:""
        }
    }
    //handleChangeEmail is used to change the email when required.
    handleChangeEmail = (event) => {
        const email = event.target.value
        this.setState({
            Email: email
        })
    }
    handleChangePassword= (event) =>  {
        const password = event.target.value
        this.setState({
            Password: password
        })
    }
   //rendor is a function.
    render() {
        return (
            <div>
                <form className='forgetPassword'>
                    <Card className='forgetCard'>
                        <div style={{ marginLeft: "68px" }}>
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
                        <div className='forgetFeilds'>
                            <TextField
                                id="outlined-Password-input"
                                label="Enter New Password*"
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
                            <Button variant="contained" color="primary" onClick={this.handleRegister} >
                                Submit
                        </Button>
                        </div>
                    </Card>
                </form>
            </div>
        )
    }
}
