import React, { Component } from 'react'
import Avatar from '@material-ui/core/Avatar'
import { withRouter } from 'react-router-dom'
import { TextField, Card, Dialog } from '@material-ui/core'
import { ImageOutlinedIcon } from '@material-ui/icons/ImageOutlined'
class ImageComponent extends Component {
    constructor(props) {
        super(props)
        this.state = {
            open: false,
            Image: "",
        }
    }
    handleClose = () => {
        this.setState({

            open: false
        });
    }

    handleToggle = (event) => {
        this.setState({
            open: !this.state.open
        });

        console.log("edit label open", event);
    }
    handleSaveImage = (e) => {
        console.log("the image value is", e.target.files[0].name);
        
        this.props.imageProps(e.target.files[0], this.props.noteId)
    }
    render() {
        return (
            <div >
                
                    <img src={require('../Assests/uploadIcon.png')} style={{ color: "#312f2f"}} onClick={() => this.fileInput.click()} />
             
                <div className='image-upload'>
                    <div><input style={{ display: "none" }} type="file" onChange={this.handleSaveImage}
                        ref={fileInput => this.fileInput = fileInput}></input></div>
                </div>
            </div>

        )
    }
}
export default withRouter(ImageComponent)
