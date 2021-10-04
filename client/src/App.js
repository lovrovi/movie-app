import './App.css';
import { useState } from 'react'
import { Movies } from './components/Movies/Movies';
import { SearchField } from './containers/SearchField/SearchField';
import { getMovies } from './redux/actions/movies/movies';

function App() {
  const [searchValue, setSearchValue] = useState("")

  const onChange = (e) => {
    setSearchValue(e.target.value)
  }

  return (
    <div>
      <SearchField
        value={searchValue}
        name="searchValue"
        handleChange={onChange}
        searchAction={getMovies}
      />
      <Movies />
    </div>
  );
}

export default App;
