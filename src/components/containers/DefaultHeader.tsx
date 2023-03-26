import styles from './Header.module.css';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { solid } from '@fortawesome/fontawesome-svg-core/import.macro'
export default function DefaultHeader(){
    return (
      <header>
        <div className={styles.headerWrapper}>
            <span>Need help? Call us: (+98) 0234 456 789</span>
            <ul className={styles.defaultList}>
              <li> <FontAwesomeIcon icon={solid("location-dot")} /> Our store</li>
              <li><FontAwesomeIcon icon={solid("truck-fast")} />Track your order</li>
            </ul>
        </div>
      </header>
    );
}