import { TimeSpan } from './timeSpan';

export interface DownloadSettings { 
    wellboreUid?: string;
    logUid?: string;
    curveId?: string;
    utcTimeOffset?: TimeSpan;
    isRealtime?: boolean;
}