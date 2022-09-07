export interface UserListQuery {
    searchQuery: string;
    page: number;
    pageSize: number;
    sortColumnName: string;
    sortAscending: boolean;
}
