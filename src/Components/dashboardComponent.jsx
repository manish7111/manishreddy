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
import DrawerComponent from './drawerComponent.jsx'
import { withRouter } from 'react-router-dom';
import { search, profileUpload, pushNOtification } from '../Services/userServices'
import GoogleLogin from 'react-google-login';
import {messaging} from '../init-fcm'
// import GetAllNotesComponent from '../Components/getAllNotesComponent.jsx'

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
    handlechange = async (event) => {
        console.log("event in search bar", event.target.value)

        await this.setState({
            Search: event.target.value
        })
        this.props.searchPropsToGetNotes(this.state.Search)
    }
    handleToggle = (event) => {
        this.setState({
            profileOpen: !this.state.profileOpen,
            anchorEl: event.currentTarget
        });
        console.log("anchor el", this.state.anchorEl);

        console.log("edit label open", this.state.profileOpen);
    }
    handleUpdate = (event) => {
        console.log("image in dash", event.target.files[0].name);
        let image = event.target.files[0];
        let email = this.state.Email;

        event.stopPropagation();
        event.preventDefault();
        event.persist();
        console.log(event.target.files[0]);
        this.setState(prevState => ({
            Image: URL.createObjectURL(event.target.files[0])
        }))


        let formData = new FormData();
        formData.append('image', image);
        formData.append('email', email)
        console.log("forma data  ", formData);


        profileUpload(formData).then((response) => {
            console.log("response data in uploading pic ", response)
        })
    }
   async onSetting(){
     let date=new Date();
     console.log("date",date)
   messaging.requestPermission().then( function(){
        console.log("have permission");
     messaging.getToken().then(function(token){
        console.log("token ",token);
     })
               
    })
      .catch(function(err){
        console.log("Unable to get permission to notify.", err);

    })
    await pushNOtification().then(response=>{
        console.log("in push ");
        
    })
//      messaging.onMessage((payload) => console.log('Message received. ', payload));
  
//  navigator.serviceWorker.addEventListener("message",(message)=>console.log("hi  hello ",message));
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
                            {this.state.view ?
                                <div className="grid-view">
                                    <GridOnOutlinedIcon onClick={this.handleGridView} />
                                </div>
                                :
                                <div className="grid-view">
                                    <DnsOutlinedIcon onClick={this.handleListView} />
                                </div>
                            }
                            <div className='setting'> <SettingsApplicationsOutlinedIcon onClick={()=>{this.onSetting()}} /></div>
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
                                                <span style={{margin:"37px 0px 0px -5px"}}>
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
                    <div className="card-div" >
                        <Card className='notecard'></Card>
                    </div>
                    {(this.state.open) ? (

                        <div className='menu-bar'>
                            <DrawerComponent menuSelect={this.state.open} />
                        </div>


                    ) : (null)
                    }
                </MuiThemeProvider>

            </div>
        )
    }
}
export default withRouter(DashBoardComponent)