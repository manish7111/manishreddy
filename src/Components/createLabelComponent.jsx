import React, { Component } from 'react';
import { withRouter } from 'react-router-dom';
import LabelOutlinedIcon from '@material-ui/icons/LabelOutlined';
import { getLabel } from '../Controllers/labelController'
import { MenuItem, Popper, Paper } from '@material-ui/core';
import Checkbox from '@material-ui/core/Checkbox'

class CreateLabelComponent extends Component {
    constructor(props) {
        super(props);
        this.state = {
            notes: [],
            Email: "",
            Id: "",
            open: false,
            Label: "",
            anchorEL: false
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
    handleClick = (key, Id) => {
        console.log("key is ----->>>>>>//////", key, Id);

        //this.props.history.push('/label', key.Label)

    }
    handleToggle = (event) => {
        console.log("event icon---->>>>>", event);

        this.setState({
            anchorEL: this.state.anchorEL ? false : event.target

        });
    }
    handleChange = (event) => {
        const Label = event.target.value
        this.setState({
            Label: Label
        })
    }
    handleClickBox = (event) => {
        console.log("check box event----------->>>>>>>>>>>>>", event.target.value,this.props.Color,this.props.noteId,this.props.Title,this.props.Desc,this.props.SenderEmail,this.props.ReceiverEmail,this.props.Reminder);
        this.props.labelProps(event.target.value,this.props.noteId,this.props.Title,this.props.Desc,this.props.Color,this.props.Reminder,this.props.SenderEmail,this.props.ReceiverEmail)
    }
    render() {
        console.log("CLC==>","noteId",this.props.noteId,"title",this.props.Title,"D",this.props.Desc,"C",this.props.Color,"R",this.props.Reminder,"SE",this.props.SenderEmail,"RE",this.props.ReceiverEmail);
        console.log("props in create Label component is ", this.props.Color);

        var data = localStorage.getItem('myData');
        console.log("data in label", data);

        this.state.Email = data;
        const get = this.state.notes.map(key => {
            return (
                (key.Email === this.state.Email) &&
                <div className='label-adding'>
                    <MenuItem onClick={() => this.handleClick(key.Label, key.Id)} className='create-label'>
                        <LabelOutlinedIcon />
                        <div>{key.Label}</div>
                        <Checkbox onClick={(e) => this.handleClickBox(e)}
                            // onChange={this.handleChange}
                            value={key.Label}
                            color="primary"
                            inputProps={{
                                'aria-label': 'secondary checkbox',
                            }}
                        />
                    </MenuItem>
                </div>
            )
        })
        return (
            <div>
                <div onClick={this.handleToggle}>Add Label</div>
                <div className='create-label-list'>
                    <Popper open={this.state.anchorEL} anchorEl={this.state.anchorEL} style={{ zIndex: "9999" }}>
                        <Paper style={{ zIndex: "9999" }}>
                            <div className='more-lebels-div' >
                                {get}
                            </div>
                        </Paper>
                    </Popper>

                </div>
            </div>
        )
    }

}
export default withRouter(CreateLabelComponent)
