import * as actionsTypes from "../../actions/actionTypes";

const initialState = {
  movies: []
};

// get movies
const getMoviesStart = (state, action) => ({
  ...state,
  getMoviesLoading: true
});

const getMoviesSuccess = (state, action) => ({
  ...state,
  movies: [...action.movies],
  getMoviesLoading: false
});

const getMoviesFail = (state, action) => ({
  ...state,
  getMoviesLoading: false
});

const reducer = (state = initialState, action) => {
    switch (action.type) {
      case actionsTypes.GET_MOVIES_START:
        return getMoviesStart(state, action);
      case actionsTypes.GET_MOVIES_SUCCESS:
        return getMoviesSuccess(state, action);
      case actionsTypes.GET_MOVIES_FAIL:
        return getMoviesFail(state, action);
      default:
        return state;
    }
  };
  
  export default reducer;