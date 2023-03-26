import styles from './Header.module.css';
import defaultStyles from '../Default.module.css';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { solid } from '@fortawesome/fontawesome-svg-core/import.macro'
import { Link } from 'react-router-dom';
export default function DefaultHeader(){
  return (
    <header className={defaultStyles.topWrapper}>
      <div className={styles.headerBlock}>
        <span>Need help? Call us: (+98) 0234 456 789</span>
        <ul className={styles.list}>
          <li>
            <Link to={"#"}>
              <FontAwesomeIcon icon={solid("location-dot")} />
              <span>Our store</span>
            </Link>
          </li>
          <li>
            <Link to={"#"}>
              <FontAwesomeIcon icon={solid("truck-fast")} />
              <span>Track your order</span>
            </Link>
          </li>
        </ul>
      </div>
    </header>
  );
}