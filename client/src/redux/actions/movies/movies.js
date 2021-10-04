import * as actionsTypes from "../actionTypes"
import axios from "../../../axios"


export const getMoviesStart = () => {
    return {
        type: actionsTypes.GET_MOVIES_START
    };
};
export const getMoviesSuccess = (movies) => {
    return {
        type: actionsTypes.GET_MOVIES_SUCCESS,
        movies
    };
};
export const getMoviesFail = () => {
    return {
        type: actionsTypes.GET_MOVIES_FAIL
    };
};

export const getMovies = (search = "", num = 10) => {
    return async (dispatch) => {
        // send request
        dispatch(getMoviesStart());
        search = encodeURIComponent(search);

        axios({
            method: "GET",
            url: "/movies",
            params: {
                search,
                num
            }
        })
            .then((data) => {
                console.log("getMovies:", data);
                dispatch(getMoviesSuccess(data.data));
            })
            .catch((e) => {
                console.error(e);
                dispatch(getMoviesFail());
            });
    };
};
