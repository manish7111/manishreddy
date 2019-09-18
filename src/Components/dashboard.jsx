/*****************************************************************************************************
 *  @Purpose        : Here we have to create the dashboard that contains all required dashboard components.
 *  @file           : dashboard.jsx       
 *  @author         : Manish Reddy
 *  @version        : v0.1
 *  @since          : 12-09-2019
 *****************************************************************************************************/

import React, { Component } from 'react'
import { AppBar, Toolbar, Button, MuiThemeProvider, createMuiTheme } from '@material-ui/core';
import IconButton from '@material-ui/core/IconButton';
import MenuIcon from '@material-ui/icons/Menu';
import { Divider, List, ListItem, ListItemIcon, ListItemText } from '@material-ui/core';
import MailIcon from '@material-ui/icons/Mail';
import DeleteIcon from '@material-ui/icons/Delete';
import CreateIcon from '@material-ui/icons/Create';
import ArchiveIcon from '@material-ui/icons/Archive';
import SearchIcon from '@material-ui/icons/Search';
import InputBase from '@material-ui/core/InputBase';
import NotificationsNoneIcon from '@material-ui/icons/NotificationsNone';


//sets the theme for the dashboard.
const theme = createMuiTheme({
    overrides: {
        MuiAppBar: {
            colorPrimary: {
                color: "black",
                backgroundColor: "white"
            }
        }
    }
})

//Dashboard is a component class which extends Component class.
class Dashboard extends Component {
    constructor(props) {
        super(props)
        this.state = {
            open: false
        }
    }
    //handleIcon is a handle state which is changable.
    handleIcon = () => {
        this.setState({
            open: !this.state.open
        })
    }

    //handleSignout is a button which hepls in signoing out from the page and redirects to login page.
    handleSignOut = () => {
        localStorage.clear();
        sessionStorage.clear();
        this.props.history.push("/login")
    }
    //rendor is a function which is used to create the dashborad with requirements.
    render() {
        return (
            <div>
                <MuiThemeProvider theme={theme}>
                    <AppBar position="static">
                        <Toolbar>
                            <IconButton edge="start" color="inherit" aria-label="Open drawer" onClick={this.handleIcon}>
                                <MenuIcon />
                            </IconButton>
                            <IconButton edge="end" color="inherit" aria-label="Open drawer" onClick={this.handleIcon}>
                                <refre />
                            </IconButton>
                            <h4>Fundoo</h4>
                            <div className='search-bar' style={{ marginLeft: "" }}>
                                <SearchIcon />
                                <InputBase
                                    placeholder="Search…"

                                    inputProps={{ 'aria-label': 'search' }}
                                />
                            </div>

                            <div className="button">
                                <Button color="primary" backgroundColor="blue" style={{ marginLeft: "750px" }} onClick={this.handleSignOut}>
                                    SignOut
                            </Button>
                            </div>
                        </Toolbar>
                    </AppBar>
                    {(this.state.open) ? (
                        <div className='menu-adjust'>

                            <Divider />
                            <List>
                                {['Notes', 'Reminders'].map((text, index) => (
                                    <ListItem button key={text}>
                                        <ListItemIcon>{index % 2 === 0 ? <MailIcon /> : <NotificationsNoneIcon />}</ListItemIcon>
                                        <ListItemText primary={text} />
                                    </ListItem>
                                ))}
                            </List>
                            <Divider />
                            <Divider />
                            <Divider />
                            <List>
                                {['EditLabels'].map((text, index) => (
                                    <ListItem button key={text}>
                                        <ListItemIcon>{index % 2 === 0 ? <CreateIcon /> : <MailIcon />}</ListItemIcon>
                                        <ListItemText primary={text} />
                                    </ListItem>
                                ))}
                            </List>
                            <Divider />

                            <Divider />
                            <List>
                                {['Archive', 'Trash'].map((text, index) => (
                                    <ListItem button key={text}>
                                        <ListItemIcon>{index % 2 === 0 ? <ArchiveIcon /> : <DeleteIcon />}</ListItemIcon>
                                        <ListItemText primary={text} />
                                    </ListItem>
                                ))}
                            </List>
                            <Divider />
                        </div>
                    ) : (null)
                    }
                </MuiThemeProvider>

            </div>
        )
    }
}

export default Dashboard;