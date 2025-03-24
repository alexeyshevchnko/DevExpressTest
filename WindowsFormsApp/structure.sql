--
-- PostgreSQL database dump
--

-- Dumped from database version 17.4
-- Dumped by pg_dump version 17.4

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: update_total_price(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.update_total_price() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    NEW."TotalPrice" := (SELECT "Price" FROM "Products" WHERE "Id" = NEW."ProductId") * NEW."Quantity";
    RETURN NEW;
END;
$$;


ALTER FUNCTION public.update_total_price() OWNER TO postgres;

--
-- Name: update_total_sales(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.update_total_sales() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    UPDATE "Clients"
    SET "TotalSales" = (
        SELECT COALESCE(SUM("si"."TotalPrice"), 0)
        FROM "Sales" "s"
        JOIN "SaleItems" "si" ON "s"."Id" = "si"."SaleId"
        WHERE "s"."ClientId" = NEW."Id"  -- замените ClientId на Id
    )
    WHERE "Id" = NEW."Id";  -- также замените ClientId на Id
    RETURN NEW;
END;
$$;


ALTER FUNCTION public.update_total_sales() OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: Clients; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Clients" (
    "Id" integer NOT NULL,
    "Name" character varying(255) NOT NULL,
    "ContactInfo" text,
    "TotalSales" numeric(10,2) DEFAULT 0
);


ALTER TABLE public."Clients" OWNER TO postgres;

--
-- Name: Clients_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Clients_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public."Clients_Id_seq" OWNER TO postgres;

--
-- Name: Clients_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Clients_Id_seq" OWNED BY public."Clients"."Id";


--
-- Name: Products; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Products" (
    "Id" integer NOT NULL,
    "Name" character varying(255) NOT NULL,
    "Price" numeric(10,2) NOT NULL
);


ALTER TABLE public."Products" OWNER TO postgres;

--
-- Name: Products_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Products_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public."Products_Id_seq" OWNER TO postgres;

--
-- Name: Products_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Products_Id_seq" OWNED BY public."Products"."Id";


--
-- Name: SaleItems; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."SaleItems" (
    "Id" integer NOT NULL,
    "SaleId" integer NOT NULL,
    "ProductId" integer NOT NULL,
    "Quantity" integer NOT NULL,
    "TotalPrice" numeric(10,2) NOT NULL,
    CONSTRAINT "SaleItems_Quantity_check" CHECK (("Quantity" > 0))
);


ALTER TABLE public."SaleItems" OWNER TO postgres;

--
-- Name: SaleItems_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."SaleItems_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public."SaleItems_Id_seq" OWNER TO postgres;

--
-- Name: SaleItems_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."SaleItems_Id_seq" OWNED BY public."SaleItems"."Id";


--
-- Name: Sales; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Sales" (
    "Id" integer NOT NULL,
    "ClientId" integer NOT NULL,
    "SaleDate" timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);


ALTER TABLE public."Sales" OWNER TO postgres;

--
-- Name: Sales_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Sales_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public."Sales_Id_seq" OWNER TO postgres;

--
-- Name: Sales_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Sales_Id_seq" OWNED BY public."Sales"."Id";


--
-- Name: Clients Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Clients" ALTER COLUMN "Id" SET DEFAULT nextval('public."Clients_Id_seq"'::regclass);


--
-- Name: Products Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Products" ALTER COLUMN "Id" SET DEFAULT nextval('public."Products_Id_seq"'::regclass);


--
-- Name: SaleItems Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."SaleItems" ALTER COLUMN "Id" SET DEFAULT nextval('public."SaleItems_Id_seq"'::regclass);


--
-- Name: Sales Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Sales" ALTER COLUMN "Id" SET DEFAULT nextval('public."Sales_Id_seq"'::regclass);


--
-- Name: Clients Clients_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Clients"
    ADD CONSTRAINT "Clients_pkey" PRIMARY KEY ("Id");


--
-- Name: Products Products_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Products"
    ADD CONSTRAINT "Products_pkey" PRIMARY KEY ("Id");


--
-- Name: SaleItems SaleItems_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."SaleItems"
    ADD CONSTRAINT "SaleItems_pkey" PRIMARY KEY ("Id");


--
-- Name: Sales Sales_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Sales"
    ADD CONSTRAINT "Sales_pkey" PRIMARY KEY ("Id");


--
-- Name: SaleItems trigger_update_total_price; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER trigger_update_total_price BEFORE INSERT OR UPDATE ON public."SaleItems" FOR EACH ROW EXECUTE FUNCTION public.update_total_price();


--
-- Name: SaleItems SaleItems_ProductId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."SaleItems"
    ADD CONSTRAINT "SaleItems_ProductId_fkey" FOREIGN KEY ("ProductId") REFERENCES public."Products"("Id") ON DELETE CASCADE;


--
-- Name: SaleItems SaleItems_SaleId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."SaleItems"
    ADD CONSTRAINT "SaleItems_SaleId_fkey" FOREIGN KEY ("SaleId") REFERENCES public."Sales"("Id") ON DELETE CASCADE;


--
-- Name: Sales Sales_ClientId_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Sales"
    ADD CONSTRAINT "Sales_ClientId_fkey" FOREIGN KEY ("ClientId") REFERENCES public."Clients"("Id") ON DELETE CASCADE;


--
-- Name: SCHEMA public; Type: ACL; Schema: -; Owner: pg_database_owner
--

GRANT USAGE ON SCHEMA public TO root;


--
-- Name: TABLE "Clients"; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public."Clients" TO root;


--
-- Name: SEQUENCE "Clients_Id_seq"; Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON SEQUENCE public."Clients_Id_seq" TO root;


--
-- Name: TABLE "Products"; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public."Products" TO root;


--
-- Name: SEQUENCE "Products_Id_seq"; Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON SEQUENCE public."Products_Id_seq" TO root;


--
-- Name: TABLE "SaleItems"; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public."SaleItems" TO root;


--
-- Name: SEQUENCE "SaleItems_Id_seq"; Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON SEQUENCE public."SaleItems_Id_seq" TO root;


--
-- Name: TABLE "Sales"; Type: ACL; Schema: public; Owner: postgres
--

GRANT SELECT,INSERT,DELETE,UPDATE ON TABLE public."Sales" TO root;


--
-- Name: SEQUENCE "Sales_Id_seq"; Type: ACL; Schema: public; Owner: postgres
--

GRANT ALL ON SEQUENCE public."Sales_Id_seq" TO root;


--
-- PostgreSQL database dump complete
--

