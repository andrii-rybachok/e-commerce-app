import { Form } from "react-router-dom";
import styles from './Search.module.css';

export default function SearchBar(){
  return (
    <>
      <Form id={styles["serachForm"]} role="search">
        <input
          type="search"
          id={styles["productSearch"]}
          placeholder="Search any things"
          
        />
        <input type="submit" className={styles.searchBtn} value="Search" />
      </Form>
    </>
  );
}