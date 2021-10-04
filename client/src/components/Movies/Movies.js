import { useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { getMovies } from '../../redux/actions/movies/movies';
import { MovieCard } from './MovieCard';
import './Movies.css'

export const Movies = () => {
    const dispatch = useDispatch();
    const [items, setItems] = useState(10);
    const movies = useSelector(state => state.movies.movies)
    const getMoviesLoading = useSelector(state => state.movies.getMoviesLoading)


    useEffect(() => {
        dispatch(getMovies());
    }, [dispatch])

    const moviesRender = () => {
        return movies.map((movie, index) => {
            return (
                <MovieCard movie={movie} key={index}/>
            )
        })
    }

    return (
        <div className="movies">
            {moviesRender()}
        </div>
    )
}
