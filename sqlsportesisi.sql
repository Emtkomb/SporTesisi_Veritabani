PGDMP         "                z            sqlsportesisi    15.0    15.0 j    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16579    sqlsportesisi    DATABASE     �   CREATE DATABASE sqlsportesisi WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Turkish_Turkey.1254';
    DROP DATABASE sqlsportesisi;
                postgres    false                        2615    16580 
   sportesisi    SCHEMA        CREATE SCHEMA sportesisi;
    DROP SCHEMA sportesisi;
                postgres    false            �            1259    16629    Personel    TABLE     �   CREATE TABLE sportesisi."Personel" (
    personelid integer NOT NULL,
    adi character varying(40) NOT NULL,
    soyadi character varying(40) NOT NULL,
    maas character varying(20) NOT NULL
);
 "   DROP TABLE sportesisi."Personel";
    
   sportesisi         heap    postgres    false    5            �            1259    16628    Personel_personelid_seq    SEQUENCE     �   CREATE SEQUENCE sportesisi."Personel_personelid_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 4   DROP SEQUENCE sportesisi."Personel_personelid_seq";
    
   sportesisi          postgres    false    216    5            �           0    0    Personel_personelid_seq    SEQUENCE OWNED BY     _   ALTER SEQUENCE sportesisi."Personel_personelid_seq" OWNED BY sportesisi."Personel".personelid;
       
   sportesisi          postgres    false    215            �            1259    16713    basketbolSahasi    TABLE     w   CREATE TABLE sportesisi."basketbolSahasi" (
    "sahaId" integer NOT NULL,
    "basketbolSahasiNo" integer NOT NULL
);
 )   DROP TABLE sportesisi."basketbolSahasi";
    
   sportesisi         heap    postgres    false    5            �            1259    16712 %   basketbolSahasi_basketbolSahasiId_seq    SEQUENCE     �   CREATE SEQUENCE sportesisi."basketbolSahasi_basketbolSahasiId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 B   DROP SEQUENCE sportesisi."basketbolSahasi_basketbolSahasiId_seq";
    
   sportesisi          postgres    false    5    224            �           0    0 %   basketbolSahasi_basketbolSahasiId_seq    SEQUENCE OWNED BY     r   ALTER SEQUENCE sportesisi."basketbolSahasi_basketbolSahasiId_seq" OWNED BY sportesisi."basketbolSahasi"."sahaId";
       
   sportesisi          postgres    false    223            �            1259    16635    calisan    TABLE     e   CREATE TABLE sportesisi.calisan (
    personelid integer NOT NULL,
    calisanno integer NOT NULL
);
    DROP TABLE sportesisi.calisan;
    
   sportesisi         heap    postgres    false    5            �            1259    24907 	   duyurular    TABLE     n   CREATE TABLE sportesisi.duyurular (
    "duyuruNo" integer NOT NULL,
    duyuru character varying NOT NULL
);
 !   DROP TABLE sportesisi.duyurular;
    
   sportesisi         heap    postgres    false    5            �            1259    16721    futbolSahasi    TABLE     q   CREATE TABLE sportesisi."futbolSahasi" (
    "sahaId" integer NOT NULL,
    "futbolSahasiNo" integer NOT NULL
);
 &   DROP TABLE sportesisi."futbolSahasi";
    
   sportesisi         heap    postgres    false    5            �            1259    16720    futbolSahasi_futbolSahasiId_seq    SEQUENCE     �   CREATE SEQUENCE sportesisi."futbolSahasi_futbolSahasiId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 <   DROP SEQUENCE sportesisi."futbolSahasi_futbolSahasiId_seq";
    
   sportesisi          postgres    false    226    5            �           0    0    futbolSahasi_futbolSahasiId_seq    SEQUENCE OWNED BY     i   ALTER SEQUENCE sportesisi."futbolSahasi_futbolSahasiId_seq" OWNED BY sportesisi."futbolSahasi"."sahaId";
       
   sportesisi          postgres    false    225            �            1259    16742    havuzSalonu    TABLE     n   CREATE TABLE sportesisi."havuzSalonu" (
    "sahaId" integer NOT NULL,
    "havuzSalonNo" integer NOT NULL
);
 %   DROP TABLE sportesisi."havuzSalonu";
    
   sportesisi         heap    postgres    false    5            �            1259    16741    havuzSalonu_havuzId_seq    SEQUENCE     �   CREATE SEQUENCE sportesisi."havuzSalonu_havuzId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 4   DROP SEQUENCE sportesisi."havuzSalonu_havuzId_seq";
    
   sportesisi          postgres    false    5    232            �           0    0    havuzSalonu_havuzId_seq    SEQUENCE OWNED BY     `   ALTER SEQUENCE sportesisi."havuzSalonu_havuzId_seq" OWNED BY sportesisi."havuzSalonu"."sahaId";
       
   sportesisi          postgres    false    231            �            1259    25036    il    TABLE     o   CREATE TABLE sportesisi.il (
    "ilplakaKodu" integer NOT NULL,
    "ilAdi" character varying(30) NOT NULL
);
    DROP TABLE sportesisi.il;
    
   sportesisi         heap    postgres    false    5            �            1259    25031    ilce    TABLE     �   CREATE TABLE sportesisi.ilce (
    "ilceNo" integer NOT NULL,
    "ilceAdi" character varying(20) NOT NULL,
    "ilplakaKodu" integer NOT NULL
);
    DROP TABLE sportesisi.ilce;
    
   sportesisi         heap    postgres    false    5            �            1259    16798    iletisimBilgileri    TABLE     �   CREATE TABLE sportesisi."iletisimBilgileri" (
    no integer NOT NULL,
    telefon character varying(11) NOT NULL,
    adres character varying(50) NOT NULL,
    personelid integer NOT NULL,
    "ilceNo" integer
);
 +   DROP TABLE sportesisi."iletisimBilgileri";
    
   sportesisi         heap    postgres    false    5            �            1259    16774    sahaKiralama    TABLE     �   CREATE TABLE sportesisi."sahaKiralama" (
    "kiraNo" integer NOT NULL,
    "saatlikUcret" integer NOT NULL,
    "kiraSuresi" integer NOT NULL,
    ucret integer NOT NULL
);
 &   DROP TABLE sportesisi."sahaKiralama";
    
   sportesisi         heap    postgres    false    5            �            1259    16773    sahaKiralama_sahaKiraNo_seq    SEQUENCE     �   CREATE SEQUENCE sportesisi."sahaKiralama_sahaKiraNo_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 8   DROP SEQUENCE sportesisi."sahaKiralama_sahaKiraNo_seq";
    
   sportesisi          postgres    false    5    234            �           0    0    sahaKiralama_sahaKiraNo_seq    SEQUENCE OWNED BY     e   ALTER SEQUENCE sportesisi."sahaKiralama_sahaKiraNo_seq" OWNED BY sportesisi."sahaKiralama"."kiraNo";
       
   sportesisi          postgres    false    233            �            1259    16678    sahalar    TABLE     �   CREATE TABLE sportesisi.sahalar (
    "sahaId" integer NOT NULL,
    "sahaAdi" character varying NOT NULL,
    "kiraNo" integer NOT NULL
);
    DROP TABLE sportesisi.sahalar;
    
   sportesisi         heap    postgres    false    5            �            1259    16677    saha_sahaNo_seq    SEQUENCE     �   CREATE SEQUENCE sportesisi."saha_sahaNo_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE sportesisi."saha_sahaNo_seq";
    
   sportesisi          postgres    false    5    222            �           0    0    saha_sahaNo_seq    SEQUENCE OWNED BY     R   ALTER SEQUENCE sportesisi."saha_sahaNo_seq" OWNED BY sportesisi.sahalar."sahaId";
       
   sportesisi          postgres    false    221            �            1259    16735    tenisSahasi    TABLE     o   CREATE TABLE sportesisi."tenisSahasi" (
    "sahaId" integer NOT NULL,
    "tenisSahasiNo" integer NOT NULL
);
 %   DROP TABLE sportesisi."tenisSahasi";
    
   sportesisi         heap    postgres    false    5            �            1259    16734    tenisSahasi_tenisSahasiId_seq    SEQUENCE     �   CREATE SEQUENCE sportesisi."tenisSahasi_tenisSahasiId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 :   DROP SEQUENCE sportesisi."tenisSahasi_tenisSahasiId_seq";
    
   sportesisi          postgres    false    230    5            �           0    0    tenisSahasi_tenisSahasiId_seq    SEQUENCE OWNED BY     f   ALTER SEQUENCE sportesisi."tenisSahasi_tenisSahasiId_seq" OWNED BY sportesisi."tenisSahasi"."sahaId";
       
   sportesisi          postgres    false    229            �            1259    16671    tesis    TABLE     �   CREATE TABLE sportesisi.tesis (
    "tesisID" integer NOT NULL,
    "sahaNo" integer NOT NULL,
    personelid integer NOT NULL,
    "duyuruNo" integer NOT NULL,
    "tesisAdi" character varying(30) NOT NULL,
    sehir character varying(30) NOT NULL
);
    DROP TABLE sportesisi.tesis;
    
   sportesisi         heap    postgres    false    5            �            1259    16797    tesisAdresi_tesisNo_seq    SEQUENCE     �   CREATE SEQUENCE sportesisi."tesisAdresi_tesisNo_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 4   DROP SEQUENCE sportesisi."tesisAdresi_tesisNo_seq";
    
   sportesisi          postgres    false    5    236            �           0    0    tesisAdresi_tesisNo_seq    SEQUENCE OWNED BY     `   ALTER SEQUENCE sportesisi."tesisAdresi_tesisNo_seq" OWNED BY sportesisi."iletisimBilgileri".no;
       
   sportesisi          postgres    false    235            �            1259    16670    tesis_tesisNo_seq    SEQUENCE     �   CREATE SEQUENCE sportesisi."tesis_tesisNo_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE sportesisi."tesis_tesisNo_seq";
    
   sportesisi          postgres    false    5    220            �           0    0    tesis_tesisNo_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE sportesisi."tesis_tesisNo_seq" OWNED BY sportesisi.tesis."tesisID";
       
   sportesisi          postgres    false    219            �            1259    16640    tesisgorevlisi    TABLE     l   CREATE TABLE sportesisi.tesisgorevlisi (
    personelid integer NOT NULL,
    gorevlino integer NOT NULL
);
 &   DROP TABLE sportesisi.tesisgorevlisi;
    
   sportesisi         heap    postgres    false    5            �            1259    16728    voleybolSahasi    TABLE     u   CREATE TABLE sportesisi."voleybolSahasi" (
    "sahaId" integer NOT NULL,
    "voleybolSahasiNo" integer NOT NULL
);
 (   DROP TABLE sportesisi."voleybolSahasi";
    
   sportesisi         heap    postgres    false    5            �            1259    16727 #   voleybolSahasi_voleybolSahasiId_seq    SEQUENCE     �   CREATE SEQUENCE sportesisi."voleybolSahasi_voleybolSahasiId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 @   DROP SEQUENCE sportesisi."voleybolSahasi_voleybolSahasiId_seq";
    
   sportesisi          postgres    false    228    5            �           0    0 #   voleybolSahasi_voleybolSahasiId_seq    SEQUENCE OWNED BY     o   ALTER SEQUENCE sportesisi."voleybolSahasi_voleybolSahasiId_seq" OWNED BY sportesisi."voleybolSahasi"."sahaId";
       
   sportesisi          postgres    false    227            �           2604    16632    Personel personelid    DEFAULT     �   ALTER TABLE ONLY sportesisi."Personel" ALTER COLUMN personelid SET DEFAULT nextval('sportesisi."Personel_personelid_seq"'::regclass);
 H   ALTER TABLE sportesisi."Personel" ALTER COLUMN personelid DROP DEFAULT;
    
   sportesisi          postgres    false    215    216    216            �           2604    16716    basketbolSahasi sahaId    DEFAULT     �   ALTER TABLE ONLY sportesisi."basketbolSahasi" ALTER COLUMN "sahaId" SET DEFAULT nextval('sportesisi."basketbolSahasi_basketbolSahasiId_seq"'::regclass);
 M   ALTER TABLE sportesisi."basketbolSahasi" ALTER COLUMN "sahaId" DROP DEFAULT;
    
   sportesisi          postgres    false    223    224    224            �           2604    16724    futbolSahasi sahaId    DEFAULT     �   ALTER TABLE ONLY sportesisi."futbolSahasi" ALTER COLUMN "sahaId" SET DEFAULT nextval('sportesisi."futbolSahasi_futbolSahasiId_seq"'::regclass);
 J   ALTER TABLE sportesisi."futbolSahasi" ALTER COLUMN "sahaId" DROP DEFAULT;
    
   sportesisi          postgres    false    225    226    226            �           2604    16745    havuzSalonu sahaId    DEFAULT     �   ALTER TABLE ONLY sportesisi."havuzSalonu" ALTER COLUMN "sahaId" SET DEFAULT nextval('sportesisi."havuzSalonu_havuzId_seq"'::regclass);
 I   ALTER TABLE sportesisi."havuzSalonu" ALTER COLUMN "sahaId" DROP DEFAULT;
    
   sportesisi          postgres    false    232    231    232            �           2604    16801    iletisimBilgileri no    DEFAULT     �   ALTER TABLE ONLY sportesisi."iletisimBilgileri" ALTER COLUMN no SET DEFAULT nextval('sportesisi."tesisAdresi_tesisNo_seq"'::regclass);
 I   ALTER TABLE sportesisi."iletisimBilgileri" ALTER COLUMN no DROP DEFAULT;
    
   sportesisi          postgres    false    236    235    236            �           2604    16777    sahaKiralama kiraNo    DEFAULT     �   ALTER TABLE ONLY sportesisi."sahaKiralama" ALTER COLUMN "kiraNo" SET DEFAULT nextval('sportesisi."sahaKiralama_sahaKiraNo_seq"'::regclass);
 J   ALTER TABLE sportesisi."sahaKiralama" ALTER COLUMN "kiraNo" DROP DEFAULT;
    
   sportesisi          postgres    false    233    234    234            �           2604    16681    sahalar sahaId    DEFAULT     y   ALTER TABLE ONLY sportesisi.sahalar ALTER COLUMN "sahaId" SET DEFAULT nextval('sportesisi."saha_sahaNo_seq"'::regclass);
 C   ALTER TABLE sportesisi.sahalar ALTER COLUMN "sahaId" DROP DEFAULT;
    
   sportesisi          postgres    false    222    221    222            �           2604    16738    tenisSahasi sahaId    DEFAULT     �   ALTER TABLE ONLY sportesisi."tenisSahasi" ALTER COLUMN "sahaId" SET DEFAULT nextval('sportesisi."tenisSahasi_tenisSahasiId_seq"'::regclass);
 I   ALTER TABLE sportesisi."tenisSahasi" ALTER COLUMN "sahaId" DROP DEFAULT;
    
   sportesisi          postgres    false    230    229    230            �           2604    16674    tesis tesisID    DEFAULT     z   ALTER TABLE ONLY sportesisi.tesis ALTER COLUMN "tesisID" SET DEFAULT nextval('sportesisi."tesis_tesisNo_seq"'::regclass);
 B   ALTER TABLE sportesisi.tesis ALTER COLUMN "tesisID" DROP DEFAULT;
    
   sportesisi          postgres    false    219    220    220            �           2604    16731    voleybolSahasi sahaId    DEFAULT     �   ALTER TABLE ONLY sportesisi."voleybolSahasi" ALTER COLUMN "sahaId" SET DEFAULT nextval('sportesisi."voleybolSahasi_voleybolSahasiId_seq"'::regclass);
 L   ALTER TABLE sportesisi."voleybolSahasi" ALTER COLUMN "sahaId" DROP DEFAULT;
    
   sportesisi          postgres    false    228    227    228            n          0    16629    Personel 
   TABLE DATA           G   COPY sportesisi."Personel" (personelid, adi, soyadi, maas) FROM stdin;
 
   sportesisi          postgres    false    216   ��       v          0    16713    basketbolSahasi 
   TABLE DATA           N   COPY sportesisi."basketbolSahasi" ("sahaId", "basketbolSahasiNo") FROM stdin;
 
   sportesisi          postgres    false    224   �       o          0    16635    calisan 
   TABLE DATA           <   COPY sportesisi.calisan (personelid, calisanno) FROM stdin;
 
   sportesisi          postgres    false    217   ;�       �          0    24907 	   duyurular 
   TABLE DATA           ;   COPY sportesisi.duyurular ("duyuruNo", duyuru) FROM stdin;
 
   sportesisi          postgres    false    237   `�       x          0    16721    futbolSahasi 
   TABLE DATA           H   COPY sportesisi."futbolSahasi" ("sahaId", "futbolSahasiNo") FROM stdin;
 
   sportesisi          postgres    false    226   ��       ~          0    16742    havuzSalonu 
   TABLE DATA           E   COPY sportesisi."havuzSalonu" ("sahaId", "havuzSalonNo") FROM stdin;
 
   sportesisi          postgres    false    232   ��       �          0    25036    il 
   TABLE DATA           8   COPY sportesisi.il ("ilplakaKodu", "ilAdi") FROM stdin;
 
   sportesisi          postgres    false    239   ׂ       �          0    25031    ilce 
   TABLE DATA           F   COPY sportesisi.ilce ("ilceNo", "ilceAdi", "ilplakaKodu") FROM stdin;
 
   sportesisi          postgres    false    238   �       �          0    16798    iletisimBilgileri 
   TABLE DATA           [   COPY sportesisi."iletisimBilgileri" (no, telefon, adres, personelid, "ilceNo") FROM stdin;
 
   sportesisi          postgres    false    236   �       �          0    16774    sahaKiralama 
   TABLE DATA           [   COPY sportesisi."sahaKiralama" ("kiraNo", "saatlikUcret", "kiraSuresi", ucret) FROM stdin;
 
   sportesisi          postgres    false    234   .�       t          0    16678    sahalar 
   TABLE DATA           D   COPY sportesisi.sahalar ("sahaId", "sahaAdi", "kiraNo") FROM stdin;
 
   sportesisi          postgres    false    222   k�       |          0    16735    tenisSahasi 
   TABLE DATA           F   COPY sportesisi."tenisSahasi" ("sahaId", "tenisSahasiNo") FROM stdin;
 
   sportesisi          postgres    false    230   ��       r          0    16671    tesis 
   TABLE DATA           c   COPY sportesisi.tesis ("tesisID", "sahaNo", personelid, "duyuruNo", "tesisAdi", sehir) FROM stdin;
 
   sportesisi          postgres    false    220   ��       p          0    16640    tesisgorevlisi 
   TABLE DATA           C   COPY sportesisi.tesisgorevlisi (personelid, gorevlino) FROM stdin;
 
   sportesisi          postgres    false    218          z          0    16728    voleybolSahasi 
   TABLE DATA           L   COPY sportesisi."voleybolSahasi" ("sahaId", "voleybolSahasiNo") FROM stdin;
 
   sportesisi          postgres    false    228   ߃       �           0    0    Personel_personelid_seq    SEQUENCE SET     K   SELECT pg_catalog.setval('sportesisi."Personel_personelid_seq"', 9, true);
       
   sportesisi          postgres    false    215            �           0    0 %   basketbolSahasi_basketbolSahasiId_seq    SEQUENCE SET     Z   SELECT pg_catalog.setval('sportesisi."basketbolSahasi_basketbolSahasiId_seq"', 1, false);
       
   sportesisi          postgres    false    223            �           0    0    futbolSahasi_futbolSahasiId_seq    SEQUENCE SET     T   SELECT pg_catalog.setval('sportesisi."futbolSahasi_futbolSahasiId_seq"', 1, false);
       
   sportesisi          postgres    false    225            �           0    0    havuzSalonu_havuzId_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('sportesisi."havuzSalonu_havuzId_seq"', 1, false);
       
   sportesisi          postgres    false    231            �           0    0    sahaKiralama_sahaKiraNo_seq    SEQUENCE SET     P   SELECT pg_catalog.setval('sportesisi."sahaKiralama_sahaKiraNo_seq"', 1, false);
       
   sportesisi          postgres    false    233            �           0    0    saha_sahaNo_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('sportesisi."saha_sahaNo_seq"', 1, false);
       
   sportesisi          postgres    false    221            �           0    0    tenisSahasi_tenisSahasiId_seq    SEQUENCE SET     R   SELECT pg_catalog.setval('sportesisi."tenisSahasi_tenisSahasiId_seq"', 1, false);
       
   sportesisi          postgres    false    229            �           0    0    tesisAdresi_tesisNo_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('sportesisi."tesisAdresi_tesisNo_seq"', 1, false);
       
   sportesisi          postgres    false    235            �           0    0    tesis_tesisNo_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('sportesisi."tesis_tesisNo_seq"', 1, false);
       
   sportesisi          postgres    false    219            �           0    0 #   voleybolSahasi_voleybolSahasiId_seq    SEQUENCE SET     X   SELECT pg_catalog.setval('sportesisi."voleybolSahasi_voleybolSahasiId_seq"', 1, false);
       
   sportesisi          postgres    false    227            �           2606    16718 "   basketbolSahasi basketbolsahasi_PK 
   CONSTRAINT     n   ALTER TABLE ONLY sportesisi."basketbolSahasi"
    ADD CONSTRAINT "basketbolsahasi_PK" PRIMARY KEY ("sahaId");
 T   ALTER TABLE ONLY sportesisi."basketbolSahasi" DROP CONSTRAINT "basketbolsahasi_PK";
    
   sportesisi            postgres    false    224            �           2606    16639    calisan calisanPK 
   CONSTRAINT     ]   ALTER TABLE ONLY sportesisi.calisan
    ADD CONSTRAINT "calisanPK" PRIMARY KEY (personelid);
 A   ALTER TABLE ONLY sportesisi.calisan DROP CONSTRAINT "calisanPK";
    
   sportesisi            postgres    false    217            �           2606    24913    duyurular duyurular_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY sportesisi.duyurular
    ADD CONSTRAINT duyurular_pkey PRIMARY KEY ("duyuruNo");
 F   ALTER TABLE ONLY sportesisi.duyurular DROP CONSTRAINT duyurular_pkey;
    
   sportesisi            postgres    false    237            �           2606    16726    futbolSahasi futbolSahasi_PK 
   CONSTRAINT     h   ALTER TABLE ONLY sportesisi."futbolSahasi"
    ADD CONSTRAINT "futbolSahasi_PK" PRIMARY KEY ("sahaId");
 N   ALTER TABLE ONLY sportesisi."futbolSahasi" DROP CONSTRAINT "futbolSahasi_PK";
    
   sportesisi            postgres    false    226            �           2606    16747    havuzSalonu havuzsalon_PK 
   CONSTRAINT     e   ALTER TABLE ONLY sportesisi."havuzSalonu"
    ADD CONSTRAINT "havuzsalon_PK" PRIMARY KEY ("sahaId");
 K   ALTER TABLE ONLY sportesisi."havuzSalonu" DROP CONSTRAINT "havuzsalon_PK";
    
   sportesisi            postgres    false    232            �           2606    25040 
   il il_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY sportesisi.il
    ADD CONSTRAINT il_pkey PRIMARY KEY ("ilplakaKodu");
 8   ALTER TABLE ONLY sportesisi.il DROP CONSTRAINT il_pkey;
    
   sportesisi            postgres    false    239            �           2606    25035    ilce ilce_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY sportesisi.ilce
    ADD CONSTRAINT ilce_pkey PRIMARY KEY ("ilceNo");
 <   ALTER TABLE ONLY sportesisi.ilce DROP CONSTRAINT ilce_pkey;
    
   sportesisi            postgres    false    238            �           2606    16634    Personel personelPK 
   CONSTRAINT     a   ALTER TABLE ONLY sportesisi."Personel"
    ADD CONSTRAINT "personelPK" PRIMARY KEY (personelid);
 E   ALTER TABLE ONLY sportesisi."Personel" DROP CONSTRAINT "personelPK";
    
   sportesisi            postgres    false    216            �           2606    16683    sahalar sahaPK 
   CONSTRAINT     X   ALTER TABLE ONLY sportesisi.sahalar
    ADD CONSTRAINT "sahaPK" PRIMARY KEY ("sahaId");
 >   ALTER TABLE ONLY sportesisi.sahalar DROP CONSTRAINT "sahaPK";
    
   sportesisi            postgres    false    222            �           2606    16779    sahaKiralama sahakiralama_PK 
   CONSTRAINT     h   ALTER TABLE ONLY sportesisi."sahaKiralama"
    ADD CONSTRAINT "sahakiralama_PK" PRIMARY KEY ("kiraNo");
 N   ALTER TABLE ONLY sportesisi."sahaKiralama" DROP CONSTRAINT "sahakiralama_PK";
    
   sportesisi            postgres    false    234            �           2606    16740    tenisSahasi tenisSahasi_PK 
   CONSTRAINT     f   ALTER TABLE ONLY sportesisi."tenisSahasi"
    ADD CONSTRAINT "tenisSahasi_PK" PRIMARY KEY ("sahaId");
 L   ALTER TABLE ONLY sportesisi."tenisSahasi" DROP CONSTRAINT "tenisSahasi_PK";
    
   sportesisi            postgres    false    230            �           2606    16803     iletisimBilgileri tesisAdresi_PK 
   CONSTRAINT     f   ALTER TABLE ONLY sportesisi."iletisimBilgileri"
    ADD CONSTRAINT "tesisAdresi_PK" PRIMARY KEY (no);
 R   ALTER TABLE ONLY sportesisi."iletisimBilgileri" DROP CONSTRAINT "tesisAdresi_PK";
    
   sportesisi            postgres    false    236            �           2606    16676    tesis tesisPK 
   CONSTRAINT     X   ALTER TABLE ONLY sportesisi.tesis
    ADD CONSTRAINT "tesisPK" PRIMARY KEY ("tesisID");
 =   ALTER TABLE ONLY sportesisi.tesis DROP CONSTRAINT "tesisPK";
    
   sportesisi            postgres    false    220            �           2606    16644    tesisgorevlisi tesisgorevlisiPK 
   CONSTRAINT     k   ALTER TABLE ONLY sportesisi.tesisgorevlisi
    ADD CONSTRAINT "tesisgorevlisiPK" PRIMARY KEY (personelid);
 O   ALTER TABLE ONLY sportesisi.tesisgorevlisi DROP CONSTRAINT "tesisgorevlisiPK";
    
   sportesisi            postgres    false    218            �           2606    16733     voleybolSahasi voleybolSahasi_PK 
   CONSTRAINT     l   ALTER TABLE ONLY sportesisi."voleybolSahasi"
    ADD CONSTRAINT "voleybolSahasi_PK" PRIMARY KEY ("sahaId");
 R   ALTER TABLE ONLY sportesisi."voleybolSahasi" DROP CONSTRAINT "voleybolSahasi_PK";
    
   sportesisi            postgres    false    228            �           1259    16691    fki_tesis_FK    INDEX     J   CREATE INDEX "fki_tesis_FK" ON sportesisi.tesis USING btree (personelid);
 &   DROP INDEX sportesisi."fki_tesis_FK";
    
   sportesisi            postgres    false    220            �           2606    24933    basketbolSahasi basketsahasi    FK CONSTRAINT     �   ALTER TABLE ONLY sportesisi."basketbolSahasi"
    ADD CONSTRAINT basketsahasi FOREIGN KEY ("sahaId") REFERENCES sportesisi.sahalar("sahaId") ON UPDATE CASCADE ON DELETE CASCADE;
 L   ALTER TABLE ONLY sportesisi."basketbolSahasi" DROP CONSTRAINT basketsahasi;
    
   sportesisi          postgres    false    224    3259    222            �           2606    16645    calisan calisanPersonel    FK CONSTRAINT     �   ALTER TABLE ONLY sportesisi.calisan
    ADD CONSTRAINT "calisanPersonel" FOREIGN KEY (personelid) REFERENCES sportesisi."Personel"(personelid) ON UPDATE CASCADE ON DELETE CASCADE;
 G   ALTER TABLE ONLY sportesisi.calisan DROP CONSTRAINT "calisanPersonel";
    
   sportesisi          postgres    false    3250    216    217            �           2606    24938    futbolSahasi futbolsahasi    FK CONSTRAINT     �   ALTER TABLE ONLY sportesisi."futbolSahasi"
    ADD CONSTRAINT futbolsahasi FOREIGN KEY ("sahaId") REFERENCES sportesisi.sahalar("sahaId") ON UPDATE CASCADE ON DELETE CASCADE;
 I   ALTER TABLE ONLY sportesisi."futbolSahasi" DROP CONSTRAINT futbolsahasi;
    
   sportesisi          postgres    false    226    3259    222            �           2606    24914    tesisgorevlisi gorevliPersonel    FK CONSTRAINT     �   ALTER TABLE ONLY sportesisi.tesisgorevlisi
    ADD CONSTRAINT "gorevliPersonel" FOREIGN KEY (personelid) REFERENCES sportesisi."Personel"(personelid) ON UPDATE CASCADE ON DELETE CASCADE;
 N   ALTER TABLE ONLY sportesisi.tesisgorevlisi DROP CONSTRAINT "gorevliPersonel";
    
   sportesisi          postgres    false    3250    216    218            �           2606    24948    havuzSalonu havuzsalonu    FK CONSTRAINT     �   ALTER TABLE ONLY sportesisi."havuzSalonu"
    ADD CONSTRAINT havuzsalonu FOREIGN KEY ("sahaId") REFERENCES sportesisi.sahalar("sahaId") ON UPDATE CASCADE ON DELETE CASCADE;
 G   ALTER TABLE ONLY sportesisi."havuzSalonu" DROP CONSTRAINT havuzsalonu;
    
   sportesisi          postgres    false    232    3259    222            �           2606    25046 
   ilce il_Fk    FK CONSTRAINT     �   ALTER TABLE ONLY sportesisi.ilce
    ADD CONSTRAINT "il_Fk" FOREIGN KEY ("ilplakaKodu") REFERENCES sportesisi.il("ilplakaKodu");
 :   ALTER TABLE ONLY sportesisi.ilce DROP CONSTRAINT "il_Fk";
    
   sportesisi          postgres    false    238    239    3279            �           2606    25041    iletisimBilgileri ilce_FK    FK CONSTRAINT     �   ALTER TABLE ONLY sportesisi."iletisimBilgileri"
    ADD CONSTRAINT "ilce_FK" FOREIGN KEY ("ilceNo") REFERENCES sportesisi.ilce("ilceNo");
 K   ALTER TABLE ONLY sportesisi."iletisimBilgileri" DROP CONSTRAINT "ilce_FK";
    
   sportesisi          postgres    false    236    3277    238            �           2606    25011    iletisimBilgileri iletisim_FK    FK CONSTRAINT     �   ALTER TABLE ONLY sportesisi."iletisimBilgileri"
    ADD CONSTRAINT "iletisim_FK" FOREIGN KEY (personelid) REFERENCES sportesisi."Personel"(personelid);
 O   ALTER TABLE ONLY sportesisi."iletisimBilgileri" DROP CONSTRAINT "iletisim_FK";
    
   sportesisi          postgres    false    216    236    3250            �           2606    16692    tesis saha_FK    FK CONSTRAINT        ALTER TABLE ONLY sportesisi.tesis
    ADD CONSTRAINT "saha_FK" FOREIGN KEY ("sahaNo") REFERENCES sportesisi.sahalar("sahaId");
 =   ALTER TABLE ONLY sportesisi.tesis DROP CONSTRAINT "saha_FK";
    
   sportesisi          postgres    false    3259    222    220            �           2606    25026    sahalar sahakirasi_FK    FK CONSTRAINT     �   ALTER TABLE ONLY sportesisi.sahalar
    ADD CONSTRAINT "sahakirasi_FK" FOREIGN KEY ("kiraNo") REFERENCES sportesisi."sahaKiralama"("kiraNo");
 E   ALTER TABLE ONLY sportesisi.sahalar DROP CONSTRAINT "sahakirasi_FK";
    
   sportesisi          postgres    false    234    3271    222            �           2606    24943    tenisSahasi tenissahasi    FK CONSTRAINT     �   ALTER TABLE ONLY sportesisi."tenisSahasi"
    ADD CONSTRAINT tenissahasi FOREIGN KEY ("sahaId") REFERENCES sportesisi.sahalar("sahaId") ON UPDATE CASCADE ON DELETE CASCADE;
 G   ALTER TABLE ONLY sportesisi."tenisSahasi" DROP CONSTRAINT tenissahasi;
    
   sportesisi          postgres    false    222    230    3259            �           2606    16686    tesis tesis_FK    FK CONSTRAINT     �   ALTER TABLE ONLY sportesisi.tesis
    ADD CONSTRAINT "tesis_FK" FOREIGN KEY (personelid) REFERENCES sportesisi."Personel"(personelid) NOT VALID;
 >   ALTER TABLE ONLY sportesisi.tesis DROP CONSTRAINT "tesis_FK";
    
   sportesisi          postgres    false    220    216    3250            �           2606    24924    tesis tesisduyuru_FK    FK CONSTRAINT     �   ALTER TABLE ONLY sportesisi.tesis
    ADD CONSTRAINT "tesisduyuru_FK" FOREIGN KEY ("duyuruNo") REFERENCES sportesisi.duyurular("duyuruNo");
 D   ALTER TABLE ONLY sportesisi.tesis DROP CONSTRAINT "tesisduyuru_FK";
    
   sportesisi          postgres    false    237    220    3275            �           2606    16650 %   tesisgorevlisi tesisgorevlisiPersonel    FK CONSTRAINT     �   ALTER TABLE ONLY sportesisi.tesisgorevlisi
    ADD CONSTRAINT "tesisgorevlisiPersonel" FOREIGN KEY (personelid) REFERENCES sportesisi."Personel"(personelid) ON UPDATE CASCADE ON DELETE CASCADE;
 U   ALTER TABLE ONLY sportesisi.tesisgorevlisi DROP CONSTRAINT "tesisgorevlisiPersonel";
    
   sportesisi          postgres    false    218    3250    216            �           2606    24953    voleybolSahasi voleybolsahasi    FK CONSTRAINT     �   ALTER TABLE ONLY sportesisi."voleybolSahasi"
    ADD CONSTRAINT voleybolsahasi FOREIGN KEY ("sahaId") REFERENCES sportesisi.sahalar("sahaId") ON UPDATE CASCADE ON DELETE CASCADE;
 M   ALTER TABLE ONLY sportesisi."voleybolSahasi" DROP CONSTRAINT voleybolsahasi;
    
   sportesisi          postgres    false    228    3259    222            n   `   x�3��M-*�<:/5�����Јˈ31'���|����geiqigjH�����˜3�8%1���<��˘���1''1C�,�(%$el����� �y      v      x������ � �      o      x�3�4�2�4����� %�      �   -   x�3�,H,J��SHI=2?3'7��|.c�ĜL��Ĥ�"�=... �p      x      x������ � �      ~      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �   -   x�3�44"c64�Ҧ@&X�ؘ�L#c.�z�r�=... U�
      t      x������ � �      |      x������ � �      r      x������ � �      p      x������ � �      z      x������ � �     