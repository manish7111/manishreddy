import React, { Component } from 'react'
import TrashComponent from '../Components/trashComponent'
import DashBoardComponent from '../Components/dashboardComponent'
import { Button } from '@material-ui/core'
import {RestoreTrash,RemoveTrash} from '../Controllers/notesController'
export default class Trash extends Component {
    handleRestore=()=>{
        RestoreTrash()
                .then((response) => {
                    console.log("Archive Notes response====>", response);
                   
                })
                .catch((err) => {
                    console.log("error occured while restoring----------", err);
                    this.setState({
                        openSnackBar: true,
                        snackBarMessage: "Error occured while Getting!!"
                    });
                });
    }
    handleTrash=()=>{
        RemoveTrash()
                .then((response) => {
                    console.log("Archive Notes response====>", response);
                   
                })
                .catch((err) => {
                    console.log("error occured while restoring----------", err);
                    this.setState({
                        openSnackBar: true,
                        snackBarMessage: "Error occured while Getting!!"
                    });
                });
    }
    render() {
        return (
            <div>
            <div><DashBoardComponent></DashBoardComponent></div>
            <div className='res-button'><Button  color="primary" onClick={this.handleRestore}>Restore All</Button><Button  color="primary" onClick={this.handleTrash}>Delete All</Button></div>
            <div className='trash-notes-alignment'><TrashComponent props={this.props}/></div>
            </div>
        )
    }
}
