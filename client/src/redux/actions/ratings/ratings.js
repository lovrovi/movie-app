import * as actionsTypes from "../actionTypes"
import axios from "../../../axios"
import { getMedias } from "../medias/medias";

export const postRatingStart = () => {
    return {
        type: actionsTypes.POST_RATING_START
    };
};
export const postRatingSuccess = () => {
    return {
        type: actionsTypes.POST_RATING_SUCCESS
    };
};
export const postRatingFail = () => {
    return {
        type: actionsTypes.POST_RATING_FAIL
    };
};

export const postRating = (rating, mediaId, mediaType) => {
    return async (dispatch) => {
        // send request
        dispatch(postRatingStart());
        axios({
            method: "POST",
            url: "/ratings",
            params: {
                rating, mediaId
            }
        })
            .then((data) => {
                dispatch(postRatingSuccess());
                dispatch(getMedias("", 10, mediaType))
            })
            .catch((e) => {
                console.error(e);
                dispatch(postRatingFail());
            });
    };
};