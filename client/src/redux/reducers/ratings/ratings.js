import * as actionsTypes from "../../actions/actionTypes";

const initialState = {
    postRatingLoading: false
};

// post rating
const postRatingLoading = (state, action) => ({
    ...state,
    postRatingLoading: true
});

const postRatingSuccess = (state, action) => ({
    ...state,
    postRatingSuccess: false
});

const postRatingFail = (state, action) => ({
    ...state,
    postRatingFail: false
});

const reducer = (state = initialState, action) => {
    switch (action.type) {
        case actionsTypes.POST_RATING_START:
            return postRatingLoading(state, action);
        case actionsTypes.POST_RATING_SUCCESS:
            return postRatingSuccess(state, action);
        case actionsTypes.POST_RATING_FAIL:
            return postRatingFail(state, action);
        default:
            return state;
    }
};

export default reducer;