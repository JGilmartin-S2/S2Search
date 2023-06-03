﻿import { AxiosGetWithQueryString, AxiosGet } from "./AxiosAPICall";

export const SearchAPI = async (request, cancellationToken) => {
  const url = "/api/search";
  return await AxiosGetWithQueryString(
    request,
    url,
    true,
    setCancellationToken(cancellationToken)
  );
};

export const SearchAndFacetsAPI = async (request, cancellationToken) => {
  const url = "/api/search";
  return await AxiosGetWithQueryString(
    request,
    url,
    false,
    setCancellationToken(cancellationToken)
  );
};

export const AutoSuggestAPI = async (searchTerm, index, cancellationToken) => {
  const url = `/api/autoSuggest?SearchTerm=${searchTerm}&index=${index}`;
  return await AxiosGet(url, true, setCancellationToken(cancellationToken));
};

export const DocumentCountAPI = async (index) => {
  const url = `/api/documentCount?index=${index}`;
  return await AxiosGet(url, true);
};

const setCancellationToken = (cancellationToken) => {
  if (process.env.NEXT_PUBLIC_ENABLE_CANCELATION_TOKEN === "false") {
    return false;
  }

  console.log(
    `NEXT_PUBLIC_ENABLE_CANCELATION_TOKEN = ${process.env.NEXT_PUBLIC_ENABLE_CANCELATION_TOKEN}`
  );

  return cancellationToken;
};
