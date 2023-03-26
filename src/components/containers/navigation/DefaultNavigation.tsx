import styles from './Navigation.module.css';
import defaultStyles from '../Default.module.css';

import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { solid ,regular} from '@fortawesome/fontawesome-svg-core/import.macro'

import { Link } from 'react-router-dom';
import SearchBar from '../../searchBar/Serchbar';
import YellowCircle from './YellowCircle';

export default function DefaultNavigation(){
    return (
      <nav>
        <section className={styles.topNavigation}>
          <div className={defaultStyles.topWrapper+" "+defaultStyles.defaultBlock}>
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
            </div>     
        </section>
        <section>
          
        </section>
      </nav>
    );
}