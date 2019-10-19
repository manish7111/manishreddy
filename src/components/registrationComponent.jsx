/*****************************************************************************************************
 *  @Purpose        : Here we have to create the RegistrationComponent that contains all required RegistrationComponent components.
 *  @file           : RegistrationComponent.jsx       
 *  @author         : Manish Reddy
 *  @version        : v0.1
 *  @since          : 12-09-2019
 *****************************************************************************************************/

import React, { Component } from 'react'
import { TextField, Card, Button, createMuiTheme, MuiThemeProvider } from '@material-ui/core';
import Snackbar from '@material-ui/core/Snackbar';
import { userRegister } from '../services/userServices';
import { withRouter } from 'react-router-dom'

const theme = createMuiTheme(
    {
        overrides: {
            MuiInputBase: {
                root: {
                    height: "76%",
                    width: "82%"
                },
                input:{
                    height: "1.2em",
                    marginTop: "-4%"
                }
            },
            MuiOutlinedInput:{
                input:{
                    padding: "18.5px 15px"
                }
            },
            MuiFormControl:{
                root:{
                    display: "flex",
                    justifycontent: "center",
                    alignitems: "center"
                }
            },
            MuiFormLabel:{
                root:{
                    fontSize: "small",
                    lineHeight: "0"
                }
            }
        }
    }
)
class RegistrationComponent extends Component {
    constructor(props) {
        super(props)
        this.state = {
            Email: "",
            FirstName: "",
            LastName: "",
            Password: ""
            
        }
    }

    handleChangeFirstName = (event) => {
        const FirstName = event.target.value
        this.setState({
            FirstName: FirstName
        })
    }
    handleChangeLastName = (event) => {
        const LastName = event.target.value
        this.setState({
            LastName: LastName
        })
    }
    handleChangeEmail = (event) => {
        const Email = event.target.value
        this.setState({
            Email: Email
        })
    }
    handleChangePassword = (event) => {
        const Password = event.target.value
        this.setState({
            Password: Password
        })
    }
    //handleSubmit is used to submit the details of the user registration.
    handleSubmit = (event) => {
        event.preventDefault();

        if (this.state.FirstName === "") {
            this.setState({
                openSnackBar: true,
                snackBarMessage: "firstName cannot be empty..!"
            });
        } else if (this.state.LastName === "") {
            this.setState({
                openSnackBar: true,
                snackBarMessage: "lastName cannot be empty..!"
            });
        } else if (this.state.Email === "") {
            this.setState({
                openSnackBar: true,
                snackBarMessage: "Email cannot be empty..!"
            });
        } else if (!/[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$/.test(this.state.Email)) {
            this.setState({
                openSnackBar: true,
                snackBarMessage: "Invalid Email..!"
            });
        } else if (this.state.Password === "") {
            this.setState({
                openSnackBar: true,
                snackBarMessage: "Password cannot be empty..!"
            });
        } else if (this.state.Password.length < 6) {
            this.setState({
                openSnackBar: true,
                snackBarMessage: "Password must be of atleast 6 characters long..!"
            });
        } else {
            var data = {
                FirstName: this.state.FirstName,
                LastName: this.state.LastName,
                Email: this.state.Email,
                Password: this.state.Password
             
            }
            userRegister(data)
                .then((response) => {
                    console.log(response);
                    this.setState({
                        openSnackBar: true,
                        snackBarMessage: "Registered Successfully!!"
                    });
                    this.props.props.history.push("/login");
                })
                .catch((err) => {
                    console.log("error in user registration----------", err);
                    this.setState({
                        openSnackBar: true,
                        snackBarMessage: "User with email id already exists!!"
                    });
                });
        }
    };

    handleLogin = () => {
        this.props.history.push('/login')
    }


    render() {
       
        return (
            <div>
                <form className='register'>
                <MuiThemeProvider theme={theme}>
                    <Card className='registerCard'>
                        <div className='div'>
                            <b>
                                <h4>
                                    <span style={{ color: "blue" }}>
                                        <blockquote>Create Account</blockquote></span>
                                </h4>
                            </b>
                        </div>

                        <div className='input1'>
                            <TextField
                                id="FirstName"
                                label="Firstname*"
                                type="Firstname"
                                name="Firstname"
                                autoComplete="Firstname"
                                margin="normal"
                                variant="outlined"
                                onChange={this.handleChangeFirstName}
                                value={this.state.FirstName}
                            />
                            <TextField
                                id="LastName"
                                label="Lastname*"
                                type="Lastname"
                                name="Lastname"
                                autoComplete="Lastname"
                                margin="normal"
                                variant="outlined"
                                onChange={this.handleChangeLastName}
                                value={this.state.LastName}
                            />
                        </div>
                        <div className='input'>
                            <TextField
                                id="Email"
                                label="Email*"
                                type="Email"
                                name="Email"
                                autoComplete="Email"
                                margin="normal"
                                variant="outlined"
                                onChange={this.handleChangeEmail}
                                value={this.state.Email}
                            />
                            <TextField
                                id="Password"
                                label="Password*"
                                type="Password"
                                name="Password"
                                autoComplete="Password"
                                margin="normal"
                                variant="outlined"
                                onChange={this.handleChangePassword}
                                value={this.state.Password}
                            />
                        </div>
                        <div className='submit'>
                            <Button variant="contained" color="primary" onClick={this.handleSubmit} >
                                Submit
                        </Button>
                            <Button variant="contained" color="primary" onClick={this.handleLogin}>
                                SignIn
                            </Button>
                           
                        </div>
                    </Card>
                    </MuiThemeProvider>
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
export default withRouter(RegistrationComponent)
