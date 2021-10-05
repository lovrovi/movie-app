import './App.css';
import { useState } from 'react'
import { Medias } from './components/Medias/Medias';
import { SearchField } from './containers/SearchField/SearchField';
import { getMedias } from './redux/actions/medias/medias';
import Box from '@mui/material/Box';
import Tab from '@mui/material/Tab';
import TabContext from '@mui/lab/TabContext';
import TabList from '@mui/lab/TabList';
import TabPanel from '@mui/lab/TabPanel';

function App() {
  const [searchValue, setSearchValue] = useState("")
  const [value, setValue] = useState('1');

  const handleChange = (event, newValue) => {
    setValue(newValue);
  };
  const onChange = (e) => {
    setSearchValue(e.target.value)
  }

  return (
    <div>
      <SearchField
        value={searchValue}
        name="searchValue"
        handleChange={onChange}
        searchAction={getMedias}
        currentTab={value}
      />
      <Box sx={{ width: '100%', typography: 'body1' }}>
        <TabContext value={value}>
          <Box sx={{ borderBottom: 1, borderColor: 'divider' }}>
            <TabList onChange={handleChange} centered>
              <Tab label="Movies" value="1" />
              <Tab label="TV Shows" value="2" />
            </TabList>
          </Box>
          <TabPanel value="1"><Medias mediaType={1}/></TabPanel>
          <TabPanel value="2"><Medias mediaType={2}/></TabPanel>
        </TabContext>
      </Box>
    </div>
  );
}

export default App;
