/*****************************************************************************************************
 *  @Purpose        : Here we have to create the dashboard that contains all required dashboard components.
 *  @file           : dashboard.jsx       
 *  @author         : Manish Reddy
 *  @version        : v0.1
 *  @since          : 12-09-2019
 *****************************************************************************************************/

import React, { Component } from 'react'
import { AppBar, Toolbar, Button, MuiThemeProvider, createMuiTheme, TextField, Avatar, Paper, Popper, Divider } from '@material-ui/core';
import IconButton from '@material-ui/core/IconButton';
import MenuIcon from '@material-ui/icons/Menu';
import SearchOutlinedIcon from '@material-ui/icons/SearchOutlined';
import RefreshOutlinedIcon from '@material-ui/icons/RefreshOutlined';
import DnsOutlinedIcon from '@material-ui/icons/DnsOutlined';
import GridOnOutlinedIcon from '@material-ui/icons/GridOnOutlined';
import SettingsApplicationsOutlinedIcon from '@material-ui/icons/SettingsApplicationsOutlined';
import InputBase from '@material-ui/core/InputBase';
import Card from '@material-ui/core/Card';

import { withRouter } from 'react-router-dom';
import GoogleLogin from 'react-google-login';

const theme = createMuiTheme({
    overrides: {
        MuiAppBar: {
            colorPrimary: {
                color: "black",
                backgroundColor: "#e8af46"
            }
        },
        MuiToolbar: {
            gutters: {
                marginbottom: "2px"
            },
            root: {
                display: "flex",
                position: "relative",
                alignItems: "center",
                // width: "100%"
            }

        },
        MuiIconButton: {
            root: {
                marginLeft: "-2%"
            }
        },
        MuiCard: {
            root: {
                // width: "20%",
                marginTop: "0.5%"
            }
        },
        MuiInputBase: {
            input: {
                padding: "8px 3px 7px"
            },
            root: {
                marginLeft: "1%",
                width: "100%",
                marginRight: "-3%"
            }
        },
        MuiButton: {
            label: {
                fontWeight: "600"
            }
        }
    }

})

class DashBoardComponent extends Component {
    constructor(props) {
        super(props)
        var pic = localStorage.getItem('ProfilePic');
        var firstName = localStorage.getItem('FirstName');
        var lastName = localStorage.getItem('LastName')
        this.state = {
            open: false,
            view: false,
            Search: "",
            profileOpen: false,
            anchorEl: null,
            Image: pic,
            Email: "",
            FirstName: firstName,
            LastName: lastName
        }
    }
    handleIcon = () => {
        this.setState({
            open: !this.state.open
        })
        console.log('yes', this.state.open)
    }
    logout = () => {
        localStorage.clear();
        this.props.history.push('/Login')

    }
    handleRefresh = () => {
        window.location.reload();
    }
    handleListView = async() => {
       await this.setState({
            view: !this.state.view
        })
        this.props.listview(this.state.view)
    }
    handleGridView = async() => {
      await  this.setState({
            view: !this.state.view
        })
        this.props.listview(this.state.view)

    }
    handlechange =  (event) => {
        
        this.props.propsToDashboard(event.target.value)
    }
    handleToggle = (event) => {
        this.setState({
            profileOpen: !this.state.profileOpen,
            anchorEl: event.currentTarget
        });
        console.log("anchor el", this.state.anchorEl);

        console.log("edit label open", this.state.profileOpen);
    }

   
    render() {
        var data = localStorage.getItem('myData');
        this.state.Email = data;

        return (
            <div >
                <MuiThemeProvider theme={theme}>
                    <AppBar position="fixed" style={{ backgroundColor: "#947a4b" }}>
                        <Toolbar>
                            <IconButton color="inherit" onClick={this.handleIcon}>
                                <MenuIcon />
                            </IconButton>
                            <img src={require("../Assests/images.png")} width="30px" height="30px"></img>
                            <div className='fundoo-title'><h4 className='fundoo-appbar' >
                               {(this.props.location.state!==undefined) ?this.props.location.state:"FundooNotes"}
                            </h4></div>
                            <div className='search-bar'>
                                <div className='class-searchIcon'>
                                    <SearchOutlinedIcon />
                                </div>
                                <div className='search'>
                                    <InputBase
                                        placeholder="Search…"
                                        inputProps={{ 'aria-label': 'search' }}
                                        value={this.state.Title}
                                        onChange={this.handlechange}
                                    />
                                </div>
                            </div>
                            <div className='refresh'><RefreshOutlinedIcon onClick={this.handleRefresh} /></div>
                            
                         
                            <div className="button">
                                <Avatar src={this.state.Image} onClick={this.handleToggle} />
                            </div>
                            <Popper open={this.state.profileOpen} anchorEl={this.state.anchorEl} style={{ zIndex: "9999", width: "22%" }} className='signout-popper'>
                                <Paper>
                                    <label htmlFor="file">
                                        <div>
                                            <div className='image-icon'>
                                                <Avatar src={this.state.Image} style={{width:"80px",height:"80px"}}/>
                                                <TextField id="file" type="file" style={{ display: 'none' }}
                                                    onChange={this.handleUpdate}

                                                />
                                                <div style={{margin:"7px -86px 0px 21px"}}>                                                
                                                    {this.state.FirstName}  
                                                    {this.state.LastName}                                                     
                                                </div>
                                                <span style={{margin:"13px 19px 0px -1px"}}>
                                                    {this.state.Email}
                                                </span>
                                            </div>
                                            <Divider style={{ marginTop: "4%", marginLeft: "9%" }} />
                                            <div className='image-icon-extension'>
                                                <Button>Add Account</Button>
                                                <Button onClick={this.logout}>SignOut</Button>
                                            </div>
                                        </div>
                                    </label>
                                </Paper>
                            </Popper>
                        </Toolbar>
                    </AppBar>
                    
                   
                </MuiThemeProvider>

            </div>
        )
    }
}
export default withRouter(DashBoardComponent)