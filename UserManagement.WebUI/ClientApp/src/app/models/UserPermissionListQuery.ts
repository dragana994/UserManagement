export interface UserPermissionListQuery {
    userId: number;
    detailMode: boolean;
    page: number;
    pageSize: number;
    sortColumnName: string;
    sortAscending: boolean;
}