import { combineReducers } from "redux";
import userReducer from '../src/Reducer/UserReducer'

export default combineReducers({
    user: userReducer
});