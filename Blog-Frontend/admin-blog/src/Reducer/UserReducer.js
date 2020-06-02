import { SET_OTP, VERIFY_OTP, All_PRODUCTS, ADDED_CART_ITEMS, DESCRIPTIONS_BY_ID, COLORS_BY_ID, SIZES_BY_ID, PRODUCT_BY_ID } from "../Action/Types";

const initialState = {
    otp: "",
    verifyOtp: "",
    allProducts: {},
    productById: {},
    sizes: {},
    colors: {},
    descriptions:{},
    addedItemsToCart: {}
};

const userReducer = (state = initialState, action) => {
    switch (action.type) {
        case SET_OTP:
            return {
                ...state,
                otp: action.payload
            };
        case VERIFY_OTP:
            return {
                ...state,
                verifyOtp: action.payload
            }
        case All_PRODUCTS:
            return {
                ...state,
                allProducts: action.payload
            }
        case PRODUCT_BY_ID:
            return {
                ...state,
                productById: action.payload
            }
        case SIZES_BY_ID:
            return {
                ...state,
                sizes: action.payload
            }
        case COLORS_BY_ID:
            return {
                ...state,
                colors: action.payload
            }
        case DESCRIPTIONS_BY_ID:
            return {
                ...state,
                descriptions: action.payload
            }
        case ADDED_CART_ITEMS:
            return {
                ...state,
                addedItemsToCart: action.payload
            }
        default:
            return state;
    }
};
export default userReducer;