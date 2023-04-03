import styles from './Navigation.module.css';
import defaultStyles from '@/Default.module.css';

import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { solid} from '@fortawesome/fontawesome-svg-core/import.macro'

import { Link } from 'react-router-dom';
import SearchBar from './searchBar/Serchbar';
import YellowCircle from './YellowCircle';

export default function DefaultNavigation(){
    return (
      <nav>
        <section className={styles.topNavigation}>
          <div className={styles.searchSide}>
            <div className={styles.logo}></div>
            <SearchBar></SearchBar>
          </div>
          <ul className={styles.list}>
            <li>
              <Link to="#">
                <FontAwesomeIcon icon={solid("user")} />
                <span>Sign in</span>
              </Link>
            </li>
            <li>
              <Link to="#">
                <FontAwesomeIcon icon={solid("heart")} />
                <YellowCircle />
                <span>Favourites</span>
              </Link>
            </li>
            <li>
              <Link to="#">
                <FontAwesomeIcon icon={solid("cart-shopping")} />
                <YellowCircle />
                <span>Cart</span>
              </Link>
            </li>
          </ul>
        </section>
        <section className={styles.bottomNavigation}>
          <button className={styles.categoriesBtn}>
            Browse categories <FontAwesomeIcon icon={solid("angle-down")} />
          </button>
          <ul className={styles.pagesList}>
            <li>
              <span>Home</span>
              <FontAwesomeIcon icon={solid("angle-down")} />
            </li>
            <li>
              <span>Catalog</span>
              <FontAwesomeIcon icon={solid("angle-down")} />
            </li>
            <li>
              <span>Blog</span>
            </li>
            <li>
              <span>Pages</span>
              <FontAwesomeIcon icon={solid("angle-down")} />
            </li>
            <li>
              <span>About us</span>
            </li>
          </ul>
          <span className={styles.freeReturn}>30 Days free return</span>
        </section>
      </nav>
    );
}