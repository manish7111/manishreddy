import React, { Component } from 'react'
import { Card, InputBase, Divider, Button,Dialog } from '@material-ui/core';
import ClearOutlinedIcon from '@material-ui/icons/ClearOutlined';
import DoneOutlinedIcon from '@material-ui/icons/DoneOutlined';
import CreateIcon from '@material-ui/icons/Create';
import {withRouter} from 'react-router-dom';
import { addLabel } from '../Controllers/labelController';
import EditLabelOpenComponent from '../Components/editLabelOpenComponent'

 class EditLabelComponent extends Component {
    constructor(props) {
        super(props);
        this.state = {
            open: false,
            Label: "",
            Email:""
        }
    }

    handleToggle = (event) => {
        this.setState({
            open: !this.state.open
        });
        console.log("edit label open",this.state.open);
    }
    handleClose=()=>{
        this.setState({
            open: false
        });
    }

    handleChangeLabel = (event) => {
        console.log("event-------->>>>>>>>>", event);
       const Label= event.target.value 
       console.log("Label--------->>>>>>",Label);
       
        this.setState({ 
            Label: Label
        });
    };
    
    handleSave=(event)=>{
        event.preventDefault();
        var data = {
            Email: this.state.Email,
            Label: this.state.Label
        }
            addLabel(data)
                .then((response) => {
                    console.log(" Notes response after updation====>", response);
                   
    
                    this.setState({
                        openSnackBar: true,
                        snackBarMessage: "Get Successfully!!"
                    });
    
    
                })
                .catch((err) => {
                    console.log("error occured while Getting----------", err);
                    this.setState({
                        openSnackBar: true,
                        snackBarMessage: "Error occured while Getting!!"
                    });
                });
        
    }
    render() {
        var data=  localStorage.getItem('myData');
        this.state.Email=data;
        return (
            <div className='edit-label'>
                <div onClick={this.handleToggle} > 
                EditLabels</div>
                <Dialog open={this.state.open} onClose={this.handleClose}>

                    <Card className='edit-label-card' style={{backgroundColor:"white"}}>
                        <div className='edit-label-div'>
                            <div>
                                <ClearOutlinedIcon />
                            </div>
                            <div>
                                <InputBase
                                    placeholder="create new label"
                                    value={this.state.Label}
                                    onChange={this.handleChangeLabel}
                                /></div>
                            <div>
                                <DoneOutlinedIcon onClick={this.handleSave}/>
                            </div>
                        </div>
                        <div>
                        <EditLabelOpenComponent/>
                        </div>
                        <Divider/>
                        <div className='label-div'>
                        <Button onClick={this.handleClose} >Done</Button>
                        </div>
                    </Card>
                </Dialog>
            </div>
        )
    }
}
export default withRouter(EditLabelComponent)