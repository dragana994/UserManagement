export interface UserListQuery {
    firstName: string;
    lastName: string;
    page: number;
    pageSize: number;
    sortColumnName: string;
    sortAscending: boolean;
}