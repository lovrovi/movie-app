import * as actionsTypes from "../actionTypes"
import axios from "../../../axios"
import { useAppendUrl } from "../../../customHooks/useAppendUrl";


export const getMediasStart = () => {
    return {
        type: actionsTypes.GET_MEDIAS_START
    };
};
export const getMediasSuccess = (medias) => {
    return {
        type: actionsTypes.GET_MEDIAS_SUCCESS,
        medias
    };
};
export const getMediasFail = () => {
    return {
        type: actionsTypes.GET_MEDIAS_FAIL
    };
};

export const getMedias = (search = "", num = 10, mediaType) => {
    return async (dispatch) => {
        // send request
        dispatch(getMediasStart());
        search = encodeURIComponent(search);

        axios({
            method: "GET",
            url: "/medias",
            params: {
                search,
                num,
                mediaType
            }
        })
            .then((data) => {
                const medias = data.data.map(media => {
                    let image = useAppendUrl(media.image)
                    return {...media, image}
                })
                dispatch(getMediasSuccess(medias));
            })
            .catch((e) => {
                console.error(e);
                dispatch(getMediasFail());
            });
    };
};
