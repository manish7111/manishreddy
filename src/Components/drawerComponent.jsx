import React, { Component } from 'react'
import { MenuItem } from '@material-ui/core'
import {withRouter} from 'react-router-dom'
import Drawer from '@material-ui/core/Drawer';
import { Divider,createMuiTheme ,MuiThemeProvider} from '@material-ui/core';
import MailIcon from '@material-ui/icons/Mail';
import DeleteIcon from '@material-ui/icons/Delete';
import CreateIcon from '@material-ui/icons/Create';
import ArchiveIcon from '@material-ui/icons/Archive';
import NotificationsNoneIcon from '@material-ui/icons/NotificationsNone';
import LabelOutlinedIcon from '@material-ui/icons/LabelOutlined';
import EditLabelComponent from '../Components/editLabelComponent';
import LabelComponent from '../Components/labelComponent'
const theme = createMuiTheme({
    overrides: {
        MuiDrawer: {
            paper: {
                top: "10.5%",
                marginLeft: "-14px",
                '@media (max-width:414px)':{
                    width:"95%",
                    backgroundColor:"dimgrey"
                }
               
            },
            paperAnchorDockedLeft:{
                border: "white",
                borderRight: "1px solid rgba(25, 23, 23, 0)",
                borderTop: "white"
            }
        },
        MuiDivider:{
            root:{
                backgroundColor: "#5d646b"
            }
        },
        MuiSvgIcon:{
            root:{
                marginTop: "-1.5%",
                marginRight: "7px",
          
            }
        },
        MuiPaper: {
            root: {
                backgroundColor: "#fff0"
               
            }
        },
        MuiMenuItem:{
            root:{
                width: "100%",
                borderBottomRightRadius: "40px",
                borderTopRightRadius: "40px",

            }
        }
    }
})
class DrawerComponent extends Component {
    constructor(props) {
        super(props)
        this.state = {
            open: false,
            appTitle:""
          
        }
    }
    handleTrash=async()=>{
       await this.setState({
            appTitle:"Trash"
        })
        this.props.history.push('/trash',this.state.appTitle);
    }
    handleClickNotes=async()=>{
        await this.setState({
            appTitle:"Fundoo Notes"
        })
        this.props.history.push('/dashboard',this.state.appTitle);
    }
    handleClickArchive=async()=>{
        await this.setState({
            appTitle:"Archive"
        })
        this.props.history.push('/archive',this.state.appTitle);
    }
    handleClickReminder=async()=>{
        await this.setState({
            appTitle:"Reminder"
        })
        this.props.history.push('/reminder',this.state.appTitle);
    }
    handleIcon = () => {
        this.setState({
            open: !this.state.open
        })
        console.log('yes', this.state.open)
    }
    handleLabel=(value)=>{
this.props.history.push('/label',value);
    }
    render() {
        return (
            <MuiThemeProvider theme={theme} >
            <div className='drawer-bar'>
            <Drawer variant="persistent" overflow="auto" open={this.props.menuSelect} className='drawerr' >
                <MenuItem id = "note" onClick={this.handleClickNotes}>
                <MailIcon/> Notes
                </MenuItem>
                <MenuItem id = "note" onClick={this.handleClickReminder}>
                <NotificationsNoneIcon/>
                Remainders
                
                </MenuItem>
                <Divider />
               
                <div className='label-align' id = "note" >
                <LabelComponent
                labelProps={this.handleLabel}
                />
                </div>
                <div className='edit-label-align'>
                <CreateIcon />
                
                <EditLabelComponent/>
                </div>
               
                <Divider />
                <MenuItem  id = "note" onClick={this.handleClickArchive}>
                <ArchiveIcon/>
                Archive
                </MenuItem>
                <MenuItem id = "note" onClick={this.handleTrash}>
                <DeleteIcon />
                Trash
                </MenuItem>
                <Divider />
                </Drawer>
            </div>
            </MuiThemeProvider>
        )
    }
}
export default withRouter(DrawerComponent)