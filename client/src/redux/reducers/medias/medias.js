import * as actionsTypes from "../../actions/actionTypes";

const initialState = {
  medias: []
};

// get medias
const getMediasStart = (state, action) => ({
  ...state,
  getMediasLoading: true
});

const getMediasSuccess = (state, action) => ({
  ...state,
  medias: [...action.medias],
  getMediasLoading: false
});

const getMediasFail = (state, action) => ({
  ...state,
  getMediasLoading: false
});

const reducer = (state = initialState, action) => {
  switch (action.type) {
    case actionsTypes.GET_MEDIAS_START:
      return getMediasStart(state, action);
    case actionsTypes.GET_MEDIAS_SUCCESS:
      return getMediasSuccess(state, action);
    case actionsTypes.GET_MEDIAS_FAIL:
      return getMediasFail(state, action);
    default:
      return state;
  }
};

export default reducer;