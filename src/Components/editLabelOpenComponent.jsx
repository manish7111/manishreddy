import React, { Component } from 'react';
import { withRouter } from 'react-router-dom';
import LabelOutlinedIcon from '@material-ui/icons/LabelOutlined';
import { getLabel, editLabel, deleteLabel } from '../Controllers/labelController'
import { MenuItem, InputBase } from '@material-ui/core';
import EditOutlinedIcon from '@material-ui/icons/EditOutlined';
import DeleteOutlineOutlinedIcon from '@material-ui/icons/DeleteOutlineOutlined';

class EditLabelOpenComponent extends Component {
    constructor(props) {
        super(props);
        this.state = {
            notes: [],
            Email: "",
            Id: "",
            open: false,
            Label: ""
        }
    }
    componentDidMount() {
        this.getLabels()
    }
    getLabels = () => {
        getLabel(this.state.Email).then((response) => {
            console.log('response is after getting', response);
            this.setState({
                notes: response.data.result
            })
            console.log("list of label notes is", this.state.notes);
        })
    }
    handleClick = async (key, Id) => {
        console.log("key is ----->>>>>>//////", key, Id);

        this.setState({
            Label: key,
            Id: Id
        })
        console.log("edit ;label key and id......----->>>>", this.state.Id, this.state.Label);

        var data = {
            Id: this.state.Id,
            Label: this.state.Label
        }

        await editLabel(data).then((response) => {
            console.log("response data of Edit label", response);

            this.getLabels();
        })
    }
    handleChange = (event) => {
        console.log("event log in edit label", event.target.value);

        this.setState({
            Label: event.target.value
        })
        console.log("after set state label",this.state.Label);
        
    }
    handleDelete = (key) => {
        console.log("key is ----->>>>>>//////", key);
        this.setState({
            Id: key
        })
        var data = {
            Id: key
        }
        deleteLabel(data).then((response) => {
            console.log("response data of Edit label", response);

            this.getLabels();
        })
    }

    render() {

        var data = localStorage.getItem('myData');
        console.log("data in label", data);

        this.state.Email = data;
        const get = this.state.notes.map(key => {
            return (
                (key.Email === this.state.Email) &&
                <div className='edit-label-adding' >
                    <MenuItem key={key.Id}>
                        <DeleteOutlineOutlinedIcon onClick={() => this.handleDelete(key.Id)} />
                        <InputBase
                            multiline
                            // placeholder={key.Label}
                            id="Label"
                            defaultValue={key.Label}
                            onChange={this.handleChange}

                        />
                        <div className='edit-editbutton'>
                            <EditOutlinedIcon onClick={() => this.handleClick(this.state.Label, key.Id)} />
                        </div>
                    </MenuItem>
                </div>
            )
        })
        return (
            <div className='label-list'>
                {get}
            </div>
        )
    }

}
export default withRouter(EditLabelOpenComponent)
