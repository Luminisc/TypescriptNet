import { DownloadSettings } from './downloadSettings';
import { MappingSettings } from './mappingSettings';
import { TaskStatus } from './taskStatus';

export interface UploadTask { 
    id?: string;
    name?: string;
    title?: string;
    readonly type?: string;
    deserializedId?: string;
    deserializedName?: string;
    deserializedTitle?: string;
    wellUid?: string;
    downloadSettings?: DownloadSettings;
    mappingSettings?: MappingSettings;
    status?: TaskStatus;
    statusMessage?: string;
    statusTimestamp?: Date;
}