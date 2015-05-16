
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class stonevilla2Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {491, -5, -7, 1}, {491, -5, -7, 3}, {466, -5, -7, 6}// 1	2	3	
			, {491, -5, -7, 26}, {491, -5, -7, 29}, {490, -5, -6, 1}// 4	5	6	
			, {490, -5, -6, 3}, {465, -5, -6, 6}, {490, -5, -6, 26}// 7	8	9	
			, {490, -5, -6, 29}, {490, -5, -5, 1}, {490, -5, -5, 3}// 10	11	12	
			, {465, -5, -5, 6}, {2182, -5, -5, 26}, {490, -5, -4, 1}// 13	14	15	
			, {490, -5, -4, 3}, {465, -5, -4, 6}, {2182, -5, -4, 26}// 16	17	18	
			, {490, -5, -3, 1}, {490, -5, -3, 3}, {465, -5, -3, 6}// 19	20	21	
			, {2182, -5, -3, 26}, {490, -5, -2, 1}, {490, -5, -2, 3}// 22	23	24	
			, {465, -5, -2, 6}, {2182, -5, -2, 26}, {490, -5, -1, 1}// 25	26	27	
			, {490, -5, -1, 3}, {465, -5, -1, 6}, {490, -5, -1, 26}// 28	29	30	
			, {490, -5, -1, 29}, {489, -4, -7, 1}, {489, -4, -7, 3}// 31	32	33	
			, {464, -4, -7, 6}, {489, -4, -7, 26}, {489, -4, -7, 29}// 34	35	36	
			, {1308, -4, -6, 6}, {1305, -4, -6, 26}, {1305, -4, -5, 6}// 37	38	39	
			, {1308, -4, -5, 26}, {1311, -4, -4, 6}, {1312, -4, -4, 26}// 40	41	42	
			, {1305, -4, -3, 6}, {1312, -4, -3, 26}, {1308, -4, -2, 6}// 43	44	45	
			, {1308, -4, -2, 26}, {1312, -4, -1, 6}, {1311, -4, -1, 26}// 46	47	48	
			, {489, -3, -7, 1}, {489, -3, -7, 3}, {464, -3, -7, 6}// 49	50	51	
			, {2176, -3, -7, 26}, {1311, -3, -6, 6}, {1312, -3, -6, 26}// 52	53	54	
			, {1305, -3, -5, 6}, {1312, -3, -5, 26}, {1305, -3, -4, 6}// 55	56	57	
			, {1306, -3, -4, 26}, {1305, -3, -3, 6}, {1307, -3, -3, 26}// 58	59	60	
			, {1305, -3, -2, 6}, {1312, -3, -2, 26}, {1307, -3, -1, 6}// 61	62	63	
			, {1306, -3, -1, 26}, {489, -2, -7, 1}, {489, -2, -7, 3}// 64	65	66	
			, {464, -2, -7, 6}, {2176, -2, -7, 26}, {1308, -2, -6, 6}// 67	68	69	
			, {1307, -2, -6, 26}, {1306, -2, -5, 6}, {1306, -2, -5, 26}// 70	71	72	
			, {1306, -2, -4, 6}, {1307, -2, -4, 26}, {1312, -2, -3, 6}// 73	74	75	
			, {1306, -2, -3, 26}, {1308, -2, -2, 6}, {1306, -2, -2, 26}// 76	77	78	
			, {1312, -2, -1, 6}, {1308, -2, -1, 26}, {489, -1, -7, 1}// 79	80	81	
			, {489, -1, -7, 3}, {312, -1, -7, 6}, {489, -1, -7, 26}// 82	83	84	
			, {466, -1, -7, 26}, {489, -1, -7, 29}, {491, -1, -7, 46}// 85	86	87	
			, {1311, -1, -6, 6}, {1312, -1, -6, 26}, {465, -1, -6, 26}// 88	89	90	
			, {490, -1, -6, 46}, {1307, -1, -5, 6}, {1308, -1, -5, 26}// 91	92	93	
			, {465, -1, -5, 26}, {490, -1, -5, 46}, {1312, -1, -4, 6}// 94	95	96	
			, {1307, -1, -4, 26}, {472, -1, -4, 26}, {490, -1, -4, 46}// 97	98	99	
			, {1305, -1, -3, 6}, {1305, -1, -3, 26}, {473, -1, -3, 26}// 100	101	102	
			, {490, -1, -3, 46}, {1305, -1, -2, 6}, {1311, -1, -2, 26}// 103	104	105	
			, {465, -1, -2, 26}, {490, -1, -2, 46}, {1305, -1, -1, 6}// 106	107	108	
			, {1305, -1, -1, 26}, {465, -1, -1, 26}, {490, -1, -1, 46}// 109	110	111	
			, {489, 0, -7, 1}, {489, 0, -7, 3}, {464, 0, -7, 26}// 112	113	115	
			, {489, 0, -7, 46}, {1308, 0, -6, 6}, {1306, 0, -6, 26}// 116	117	118	
			, {1306, 0, -6, 46}, {1877, 0, -6, 51}, {1305, 0, -5, 6}// 119	120	121	
			, {1312, 0, -5, 26}, {1307, 0, -5, 46}, {1876, 0, -5, 51}// 122	123	124	
			, {1311, 0, -4, 6}, {1306, 0, -4, 26}, {1311, 0, -4, 46}// 125	126	127	
			, {1876, 0, -4, 51}, {1307, 0, -3, 6}, {1311, 0, -3, 26}// 128	129	130	
			, {1312, 0, -3, 46}, {1876, 0, -3, 51}, {1311, 0, -2, 6}// 131	132	133	
			, {1305, 0, -2, 26}, {1311, 0, -2, 46}, {1876, 0, -2, 51}// 134	135	136	
			, {1312, 0, -1, 6}, {1312, 0, -1, 26}, {1305, 0, -1, 46}// 137	138	139	
			, {1876, 0, -1, 51}, {489, 1, -7, 1}, {489, 1, -7, 3}// 140	141	142	
			, {307, 1, -7, 6}, {464, 1, -7, 26}, {489, 1, -7, 46}// 143	144	145	
			, {1312, 1, -6, 6}, {1307, 1, -6, 26}, {1308, 1, -6, 46}// 146	147	148	
			, {1875, 1, -6, 51}, {1306, 1, -5, 6}, {1312, 1, -5, 26}// 149	150	151	
			, {1306, 1, -5, 46}, {1315, 1, -5, 56}, {491, 1, -5, 62}// 152	153	154	
			, {491, 1, -5, 65}, {1308, 1, -4, 6}, {1307, 1, -4, 26}// 155	156	157	
			, {1305, 1, -4, 46}, {1315, 1, -4, 56}, {490, 1, -4, 62}// 158	159	160	
			, {491, 1, -4, 65}, {1312, 1, -3, 6}, {1311, 1, -3, 26}// 161	162	163	
			, {1305, 1, -3, 46}, {1315, 1, -3, 56}, {490, 1, -3, 62}// 164	165	166	
			, {491, 1, -3, 65}, {1311, 1, -2, 6}, {1308, 1, -2, 26}// 167	168	169	
			, {1312, 1, -2, 46}, {1315, 1, -2, 56}, {490, 1, -2, 62}// 170	171	172	
			, {491, 1, -2, 65}, {1311, 1, -1, 6}, {1306, 1, -1, 26}// 173	174	175	
			, {1305, 1, -1, 46}, {1315, 1, -1, 56}, {490, 1, -1, 62}// 176	177	178	
			, {491, 1, -1, 65}, {489, 2, -7, 1}, {489, 2, -7, 3}// 179	180	181	
			, {464, 2, -7, 6}, {464, 2, -7, 26}, {489, 2, -7, 46}// 182	183	184	
			, {1307, 2, -6, 6}, {1848, 2, -6, 6}, {1848, 2, -6, 11}// 185	186	187	
			, {1848, 2, -6, 16}, {1850, 2, -6, 21}, {1311, 2, -6, 46}// 188	189	190	
			, {1875, 2, -6, 51}, {1305, 2, -5, 6}, {1311, 2, -5, 26}// 191	192	193	
			, {2182, 2, -5, 26}, {2181, 2, -5, 11}, {1308, 2, -5, 46}// 194	195	196	
			, {1315, 2, -5, 56}, {489, 2, -5, 62}, {491, 2, -5, 65}// 197	198	199	
			, {1312, 2, -4, 6}, {1306, 2, -4, 26}, {2182, 2, -4, 26}// 200	201	202	
			, {2181, 2, -4, 6}, {1306, 2, -4, 46}, {1315, 2, -4, 56}// 203	204	205	
			, {1308, 2, -3, 6}, {1306, 2, -3, 26}, {2182, 2, -3, 26}// 206	207	208	
			, {1305, 2, -3, 46}, {1315, 2, -3, 56}, {1308, 2, -2, 6}// 209	210	211	
			, {1312, 2, -2, 26}, {1305, 2, -2, 46}, {1315, 2, -2, 56}// 212	213	214	
			, {1312, 2, -1, 6}, {1311, 2, -1, 26}, {1307, 2, -1, 46}// 215	216	217	
			, {1315, 2, -1, 56}, {489, 3, -7, 1}, {489, 3, -7, 3}// 218	219	220	
			, {464, 3, -7, 6}, {464, 3, -7, 26}, {489, 3, -7, 46}// 221	222	223	
			, {1305, 3, -6, 6}, {1848, 3, -6, 6}, {1848, 3, -6, 11}// 224	225	226	
			, {1861, 3, -6, 16}, {1305, 3, -6, 46}, {1875, 3, -6, 51}// 227	228	229	
			, {1306, 3, -5, 6}, {1848, 3, -5, 6}, {1849, 3, -5, 11}// 230	231	232	
			, {1306, 3, -5, 46}, {1315, 3, -5, 56}, {489, 3, -5, 62}// 233	234	235	
			, {491, 3, -5, 65}, {1306, 3, -4, 6}, {1849, 3, -4, 6}// 236	237	238	
			, {1311, 3, -4, 46}, {1315, 3, -4, 56}, {1307, 3, -3, 6}// 239	240	241	
			, {1308, 3, -3, 26}, {1312, 3, -3, 46}, {1315, 3, -3, 56}// 242	243	244	
			, {1305, 3, -2, 6}, {1307, 3, -2, 26}, {2177, 3, -2, 26}// 245	246	247	
			, {1311, 3, -2, 46}, {1315, 3, -2, 56}, {1308, 3, -1, 6}// 248	249	250	
			, {1306, 3, -1, 26}, {1311, 3, -1, 46}, {1315, 3, -1, 56}// 251	252	253	
			, {489, 4, -7, 1}, {489, 4, -7, 3}, {464, 4, -7, 6}// 254	255	256	
			, {464, 4, -7, 26}, {489, 4, -7, 46}, {490, 4, -6, 1}// 257	258	259	
			, {490, 4, -6, 3}, {1311, 4, -6, 6}, {465, 4, -6, 6}// 260	261	262	
			, {1312, 4, -6, 26}, {465, 4, -6, 26}, {490, 4, -6, 46}// 263	264	265	
			, {1307, 4, -6, 46}, {1879, 4, -6, 51}, {490, 4, -5, 1}// 266	267	268	
			, {490, 4, -5, 3}, {1306, 4, -5, 6}, {465, 4, -5, 6}// 269	270	271	
			, {1311, 4, -5, 26}, {465, 4, -5, 26}, {490, 4, -5, 46}// 272	273	274	
			, {1305, 4, -5, 46}, {1874, 4, -5, 51}, {489, 4, -5, 62}// 275	276	277	
			, {491, 4, -5, 65}, {490, 4, -4, 1}, {490, 4, -4, 3}// 278	279	280	
			, {1312, 4, -4, 6}, {465, 4, -4, 6}, {1307, 4, -4, 26}// 281	282	283	
			, {313, 4, -4, 26}, {490, 4, -4, 46}, {1306, 4, -4, 46}// 284	285	286	
			, {1874, 4, -4, 51}, {490, 4, -4, 62}, {491, 4, -4, 65}// 287	288	289	
			, {490, 4, -3, 1}, {490, 4, -3, 3}, {1308, 4, -3, 6}// 290	291	292	
			, {1312, 4, -3, 26}, {490, 4, -3, 46}, {1307, 4, -3, 46}// 293	295	296	
			, {1874, 4, -3, 51}, {490, 4, -3, 62}, {491, 4, -3, 65}// 297	298	299	
			, {490, 4, -2, 1}, {490, 4, -2, 3}, {1308, 4, -2, 6}// 300	301	302	
			, {465, 4, -2, 6}, {1312, 4, -2, 26}, {308, 4, -2, 26}// 303	304	305	
			, {490, 4, -2, 46}, {1306, 4, -2, 46}, {1874, 4, -2, 51}// 306	307	308	
			, {490, 4, -2, 62}, {491, 4, -2, 65}, {490, 4, -1, 1}// 309	310	311	
			, {490, 4, -1, 3}, {1308, 4, -1, 6}, {465, 4, -1, 6}// 312	313	314	
			, {1306, 4, -1, 26}, {465, 4, -1, 26}, {490, 4, -1, 46}// 315	316	317	
			, {1306, 4, -1, 46}, {1874, 4, -1, 51}, {490, 4, -1, 62}// 318	319	320	
			, {491, 4, -1, 65}, {464, 5, -7, 6}, {489, 5, -7, 1}// 321	322	323	
			, {489, 5, -7, 3}, {489, 5, -7, 26}, {483, 5, -7, 29}// 324	325	326	
			, {487, 5, -7, 31}, {463, 5, -6, 1}, {1928, 5, -6, 21}// 327	328	329	
			, {488, 5, -6, 26}, {483, 5, -6, 29}, {487, 5, -6, 31}// 330	331	332	
			, {1308, 5, -5, 6}, {1872, 5, -5, 1}, {1312, 5, -4, 6}// 333	334	335	
			, {1307, 5, -3, 6}, {1307, 5, -2, 6}, {1308, 5, -1, 6}// 336	337	338	
			, {1872, 5, -1, 1}, {464, 5, -1, 6}, {489, 5, -1, 26}// 339	340	341	
			, {483, 5, -1, 29}, {487, 5, -1, 31}, {490, -5, 0, 1}// 342	343	344	
			, {490, -5, 0, 3}, {465, -5, 0, 6}, {484, -5, 0, 26}// 345	346	347	
			, {490, -5, 0, 26}, {490, -5, 0, 29}, {490, -5, 1, 1}// 348	349	350	
			, {490, -5, 1, 3}, {465, -5, 1, 6}, {490, -5, 2, 1}// 351	352	353	
			, {490, -5, 2, 3}, {465, -5, 2, 6}, {490, -5, 3, 1}// 354	355	356	
			, {490, -5, 3, 3}, {465, -5, 3, 6}, {490, -5, 4, 1}// 357	358	359	
			, {490, -5, 4, 3}, {465, -5, 4, 6}, {490, -5, 5, 1}// 360	361	362	
			, {490, -5, 5, 3}, {465, -5, 5, 6}, {490, -5, 6, 1}// 363	364	365	
			, {490, -5, 6, 3}, {465, -5, 6, 6}, {490, -5, 7, 1}// 366	367	368	
			, {490, -5, 7, 3}, {465, -5, 7, 6}, {484, -5, 7, 26}// 369	370	371	
			, {9552, -5, 8, 1}, {9552, -5, 8, 6}, {485, -5, 8, 26}// 372	373	374	
			, {1307, -4, 0, 6}, {464, -4, 0, 6}, {1312, -4, 0, 26}// 375	376	377	
			, {489, -4, 0, 26}, {489, -4, 0, 29}, {1308, -4, 1, 6}// 378	379	380	
			, {1305, -4, 1, 26}, {1931, -4, 1, 31}, {1305, -4, 2, 6}// 381	382	383	
			, {1308, -4, 2, 26}, {1931, -4, 2, 35}, {1311, -4, 3, 6}// 384	385	386	
			, {1312, -4, 3, 26}, {1931, -4, 3, 39}, {1305, -4, 4, 6}// 387	388	389	
			, {1312, -4, 4, 26}, {1928, -4, 4, 40}, {1308, -4, 5, 6}// 390	391	392	
			, {1308, -4, 5, 26}, {1929, -4, 5, 39}, {1312, -4, 6, 6}// 393	394	395	
			, {1311, -4, 6, 26}, {1929, -4, 6, 35}, {489, -4, 7, 1}// 396	397	398	
			, {489, -4, 7, 3}, {1307, -4, 7, 6}, {464, -4, 7, 6}// 399	400	401	
			, {1312, -4, 7, 26}, {489, -4, 7, 26}, {489, -4, 7, 29}// 402	403	404	
			, {1929, -4, 7, 31}, {3308, -4, 8, 1}, {1306, -3, 0, 6}// 405	406	407	
			, {464, -3, 0, 6}, {1308, -3, 0, 26}, {489, -3, 0, 26}// 408	409	410	
			, {489, -3, 0, 29}, {491, -3, 0, 32}, {1311, -3, 1, 6}// 411	412	413	
			, {1312, -3, 1, 26}, {6460, -3, 1, 26}, {1305, -3, 2, 6}// 414	415	416	
			, {1312, -3, 2, 26}, {6460, -3, 2, 29}, {1305, -3, 3, 6}// 417	418	419	
			, {1306, -3, 3, 26}, {6460, -3, 3, 32}, {1305, -3, 4, 6}// 420	421	422	
			, {1307, -3, 4, 26}, {6461, -3, 4, 35}, {1305, -3, 5, 6}// 423	424	425	
			, {1312, -3, 5, 26}, {6458, -3, 5, 32}, {1307, -3, 6, 6}// 426	427	428	
			, {1306, -3, 6, 26}, {6458, -3, 6, 29}, {489, -3, 7, 1}// 429	430	431	
			, {489, -3, 7, 3}, {1306, -3, 7, 6}, {464, -3, 7, 6}// 432	433	434	
			, {1308, -3, 7, 26}, {6458, -3, 7, 26}, {489, -3, 7, 26}// 435	436	437	
			, {489, -3, 7, 29}, {489, -3, 7, 31}, {491, -3, 7, 34}// 438	439	440	
			, {3307, -3, 8, 1}, {1307, -2, 0, 6}, {1306, -2, 0, 26}// 441	442	443	
			, {312, -2, 0, 6}, {489, -2, 0, 26}, {489, -2, 0, 29}// 444	445	446	
			, {491, -2, 0, 32}, {1308, -2, 1, 6}, {1307, -2, 1, 26}// 447	448	449	
			, {6460, -2, 1, 26}, {1306, -2, 2, 6}, {1306, -2, 2, 26}// 450	451	452	
			, {6460, -2, 2, 29}, {1306, -2, 3, 6}, {1307, -2, 3, 26}// 453	454	455	
			, {6460, -2, 3, 32}, {1312, -2, 4, 6}, {1306, -2, 4, 26}// 456	457	458	
			, {6461, -2, 4, 35}, {1308, -2, 5, 6}, {1306, -2, 5, 26}// 459	460	461	
			, {6458, -2, 5, 32}, {1312, -2, 6, 6}, {1308, -2, 6, 26}// 462	463	464	
			, {6458, -2, 6, 29}, {489, -2, 7, 1}, {489, -2, 7, 3}// 465	466	467	
			, {1307, -2, 7, 6}, {464, -2, 7, 6}, {1306, -2, 7, 26}// 468	469	470	
			, {6458, -2, 7, 26}, {489, -2, 7, 26}, {489, -2, 7, 29}// 471	472	473	
			, {489, -2, 7, 31}, {491, -2, 7, 34}, {486, -2, 8, 10}// 474	475	476	
			, {490, -2, 8, 1}, {490, -2, 8, 4}, {3308, -2, 8, 1}// 477	478	479	
			, {485, -2, 8, 7}, {1307, -1, 0, 6}, {1305, -1, 0, 26}// 480	481	482	
			, {307, -1, 0, 6}, {465, -1, 0, 26}, {490, -1, 0, 46}// 483	484	485	
			, {1311, -1, 1, 6}, {1312, -1, 1, 26}, {6460, -1, 1, 26}// 486	487	488	
			, {1307, -1, 2, 6}, {1308, -1, 2, 26}, {6460, -1, 2, 29}// 489	490	491	
			, {1312, -1, 3, 6}, {1307, -1, 3, 26}, {6460, -1, 3, 32}// 492	493	494	
			, {1305, -1, 4, 6}, {1305, -1, 4, 26}, {6461, -1, 4, 35}// 495	496	497	
			, {1305, -1, 5, 6}, {1311, -1, 5, 26}, {6458, -1, 5, 32}// 498	499	500	
			, {1305, -1, 6, 6}, {1305, -1, 6, 26}, {6458, -1, 6, 29}// 501	502	503	
			, {489, -1, 7, 1}, {489, -1, 7, 3}, {1307, -1, 7, 6}// 504	505	506	
			, {1305, -1, 7, 26}, {6458, -1, 7, 26}, {489, -1, 7, 26}// 507	508	509	
			, {489, -1, 7, 29}, {489, -1, 7, 31}, {312, -1, 7, 6}// 510	511	512	
			, {491, -1, 7, 34}, {489, -1, 8, 1}, {3203, -1, 8, 4}// 513	514	515	
			, {1308, 0, 0, 6}, {1308, 0, 0, 26}, {464, 0, 0, 26}// 516	517	518	
			, {489, 0, 0, 46}, {1312, 0, 0, 46}, {1880, 0, 0, 51}// 519	520	521	
			, {1308, 0, 1, 6}, {1306, 0, 1, 26}, {6460, 0, 1, 26}// 522	523	524	
			, {1305, 0, 2, 6}, {1312, 0, 2, 26}, {6460, 0, 2, 29}// 525	526	527	
			, {1311, 0, 3, 6}, {1306, 0, 3, 26}, {6460, 0, 3, 32}// 528	529	530	
			, {1307, 0, 4, 6}, {1311, 0, 4, 26}, {6461, 0, 4, 35}// 531	532	533	
			, {1311, 0, 5, 6}, {1305, 0, 5, 26}, {6458, 0, 5, 32}// 534	535	536	
			, {1312, 0, 6, 6}, {1312, 0, 6, 26}, {6458, 0, 6, 29}// 537	538	539	
			, {489, 0, 7, 1}, {489, 0, 7, 3}, {1308, 0, 7, 6}// 540	541	542	
			, {1308, 0, 7, 26}, {6458, 0, 7, 26}, {489, 0, 7, 26}// 543	544	545	
			, {489, 0, 7, 29}, {489, 0, 7, 31}, {491, 0, 7, 34}// 546	547	549	
			, {489, 0, 8, 1}, {3206, 0, 8, 5}, {1308, 1, 0, 6}// 550	551	552	
			, {1312, 1, 0, 26}, {312, 1, 0, 6}, {312, 1, 0, 26}// 553	554	555	
			, {489, 1, 0, 46}, {1306, 1, 0, 46}, {1873, 1, 0, 51}// 556	557	558	
			, {490, 1, 0, 62}, {491, 1, 0, 65}, {1312, 1, 1, 6}// 559	560	561	
			, {1307, 1, 1, 26}, {6460, 1, 1, 26}, {1306, 1, 2, 6}// 562	563	564	
			, {1312, 1, 2, 26}, {6460, 1, 2, 29}, {1308, 1, 3, 6}// 565	566	567	
			, {1307, 1, 3, 26}, {6460, 1, 3, 32}, {1312, 1, 4, 6}// 568	569	570	
			, {1311, 1, 4, 26}, {6461, 1, 4, 35}, {1311, 1, 5, 6}// 571	572	573	
			, {1308, 1, 5, 26}, {6458, 1, 5, 32}, {1311, 1, 6, 6}// 574	575	576	
			, {1306, 1, 6, 26}, {6458, 1, 6, 29}, {489, 1, 7, 1}// 577	578	579	
			, {489, 1, 7, 3}, {1308, 1, 7, 6}, {1312, 1, 7, 26}// 580	581	582	
			, {6458, 1, 7, 26}, {489, 1, 7, 26}, {489, 1, 7, 29}// 583	584	585	
			, {489, 1, 7, 31}, {307, 1, 7, 6}, {491, 1, 7, 34}// 586	587	588	
			, {486, 1, 8, 10}, {488, 1, 8, 1}, {490, 1, 8, 4}// 589	590	591	
			, {6810, 1, 8, 4}, {485, 1, 8, 7}, {1305, 2, 0, 6}// 592	593	594	
			, {1308, 2, 0, 26}, {307, 2, 0, 6}, {489, 2, 0, 46}// 595	596	598	
			, {1305, 2, 0, 46}, {1873, 2, 0, 51}, {489, 2, 0, 62}// 599	600	601	
			, {491, 2, 0, 65}, {1307, 2, 1, 6}, {1311, 2, 1, 26}// 602	603	604	
			, {6460, 2, 1, 26}, {1305, 2, 2, 6}, {1311, 2, 2, 26}// 605	606	607	
			, {6460, 2, 2, 29}, {1312, 2, 3, 6}, {1306, 2, 3, 26}// 608	609	610	
			, {6460, 2, 3, 32}, {1308, 2, 4, 6}, {1306, 2, 4, 26}// 611	612	613	
			, {6461, 2, 4, 35}, {1308, 2, 5, 6}, {1312, 2, 5, 26}// 614	615	616	
			, {6458, 2, 5, 32}, {1312, 2, 6, 6}, {1311, 2, 6, 26}// 617	618	619	
			, {6458, 2, 6, 29}, {489, 2, 7, 1}, {489, 2, 7, 3}// 620	621	622	
			, {1305, 2, 7, 6}, {464, 2, 7, 6}, {1308, 2, 7, 26}// 623	624	625	
			, {6458, 2, 7, 26}, {489, 2, 7, 26}, {489, 2, 7, 29}// 626	627	628	
			, {489, 2, 7, 31}, {491, 2, 7, 34}, {3272, 2, 8, 1}// 629	630	631	
			, {1305, 3, 0, 6}, {464, 3, 0, 6}, {1307, 3, 0, 26}// 632	633	634	
			, {307, 3, 0, 26}, {489, 3, 0, 46}, {1306, 3, 0, 46}// 635	636	637	
			, {1873, 3, 0, 51}, {489, 3, 0, 62}, {491, 3, 0, 65}// 638	639	640	
			, {1305, 3, 1, 6}, {1312, 3, 1, 26}, {6460, 3, 1, 26}// 641	642	643	
			, {1306, 3, 2, 6}, {1306, 3, 2, 26}, {6460, 3, 2, 29}// 644	645	646	
			, {1306, 3, 3, 6}, {1311, 3, 3, 26}, {6460, 3, 3, 32}// 647	648	649	
			, {1307, 3, 4, 6}, {1308, 3, 4, 26}, {6461, 3, 4, 35}// 650	651	652	
			, {1305, 3, 5, 6}, {1307, 3, 5, 26}, {6458, 3, 5, 32}// 653	654	655	
			, {1308, 3, 6, 6}, {1306, 3, 6, 26}, {6458, 3, 6, 29}// 656	657	658	
			, {489, 3, 7, 1}, {489, 3, 7, 3}, {1305, 3, 7, 6}// 659	660	661	
			, {464, 3, 7, 6}, {1307, 3, 7, 26}, {6458, 3, 7, 26}// 662	663	664	
			, {489, 3, 7, 26}, {489, 3, 7, 29}, {489, 3, 7, 31}// 665	666	667	
			, {491, 3, 7, 34}, {488, 4, 0, 1}, {488, 4, 0, 3}// 668	669	670	
			, {1305, 4, 0, 6}, {463, 4, 0, 6}, {1306, 4, 0, 26}// 671	672	673	
			, {488, 4, 0, 26}, {463, 4, 0, 26}, {488, 4, 0, 46}// 674	675	676	
			, {1305, 4, 0, 46}, {1878, 4, 0, 51}, {488, 4, 0, 62}// 677	678	679	
			, {491, 4, 0, 65}, {490, 4, 1, 1}, {490, 4, 1, 3}// 680	681	682	
			, {1311, 4, 1, 6}, {465, 4, 1, 6}, {1312, 4, 1, 26}// 683	684	685	
			, {1931, 4, 1, 34}, {490, 4, 1, 26}, {490, 4, 1, 29}// 686	687	688	
			, {490, 4, 1, 32}, {490, 4, 2, 1}, {490, 4, 2, 3}// 689	690	691	
			, {1306, 4, 2, 6}, {465, 4, 2, 6}, {1311, 4, 2, 26}// 692	693	694	
			, {490, 4, 2, 26}, {490, 4, 2, 29}, {1931, 4, 2, 38}// 695	696	697	
			, {490, 4, 2, 32}, {490, 4, 2, 35}, {490, 4, 3, 1}// 698	699	700	
			, {490, 4, 3, 3}, {1312, 4, 3, 6}, {1307, 4, 3, 26}// 701	702	703	
			, {1931, 4, 3, 42}, {465, 4, 3, 26}, {313, 4, 3, 6}// 704	705	706	
			, {490, 4, 4, 0}, {490, 4, 4, 3}, {1308, 4, 4, 6}// 707	708	709	
			, {1312, 4, 4, 26}, {1928, 4, 4, 43}, {490, 4, 5, 1}// 710	711	714	
			, {490, 4, 5, 3}, {1308, 4, 5, 6}, {1312, 4, 5, 26}// 715	716	717	
			, {1929, 4, 5, 42}, {465, 4, 5, 26}, {308, 4, 5, 6}// 718	719	720	
			, {490, 4, 6, 1}, {490, 4, 6, 3}, {1308, 4, 6, 6}// 721	722	723	
			, {465, 4, 6, 6}, {1306, 4, 6, 26}, {490, 4, 6, 26}// 724	725	726	
			, {490, 4, 6, 29}, {1929, 4, 6, 38}, {490, 4, 6, 32}// 727	728	729	
			, {490, 4, 6, 35}, {488, 4, 7, 1}, {488, 4, 7, 3}// 730	731	732	
			, {1305, 4, 7, 6}, {463, 4, 7, 6}, {1306, 4, 7, 26}// 733	734	735	
			, {1929, 4, 7, 34}, {488, 4, 7, 26}, {488, 4, 7, 29}// 736	737	738	
			, {488, 4, 7, 32}, {16130, 4, 8, 1}, {16130, 4, 8, 12}// 739	740	741	
			, {485, 4, 8, 32}, {463, 5, 0, 1}, {488, 5, 0, 26}// 742	743	744	
			, {483, 5, 0, 29}, {1928, 5, 0, 21}, {487, 5, 0, 31}// 745	746	747	
			, {463, 5, 1, 1}, {1928, 5, 1, 21}, {1930, 5, 1, 29}// 748	749	750	
			, {488, 5, 1, 26}, {489, 5, 2, 1}, {489, 5, 2, 4}// 751	752	753	
			, {483, 5, 2, 7}, {487, 5, 2, 10}, {490, 5, 3, 1}// 754	755	756	
			, {3206, 5, 3, 5}, {490, 5, 4, 1}, {3265, 5, 4, 5}// 757	758	759	
			, {488, 5, 5, 1}, {489, 5, 5, 4}, {483, 5, 5, 7}// 760	761	762	
			, {487, 5, 5, 10}, {3212, 5, 5, 5}, {7038, 5, 6, 1}// 763	764	765	
			, {463, 5, 7, 1}, {1928, 5, 7, 21}, {1930, 5, 7, 29}// 766	767	768	
			, {488, 5, 7, 26}, {1884, 6, -5, 1}, {1874, 6, -4, 1}// 769	770	771	
			, {1874, 6, -3, 1}, {1874, 6, -2, 1}, {1882, 6, -1, 1}// 772	773	774	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new stonevilla2AddonDeed();
			}
		}

		[ Constructable ]
		public stonevilla2Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 314, 0, -7, 6, 0, 0, "", 1);// 114
			AddComplexComponent( (BaseAddon) this, 315, 4, -3, 26, 0, 0, "", 1);// 294
			AddComplexComponent( (BaseAddon) this, 314, 0, 7, 6, 0, 0, "", 1);// 548
			AddComplexComponent( (BaseAddon) this, 314, 2, 0, 26, 0, 0, "", 1);// 597
			AddComplexComponent( (BaseAddon) this, 468, 4, 4, 26, 0, 0, "", 1);// 712
			AddComplexComponent( (BaseAddon) this, 315, 4, 4, 6, 0, 0, "", 1);// 713

		}

		public stonevilla2Addon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class stonevilla2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new stonevilla2Addon();
			}
		}

		[Constructable]
		public stonevilla2AddonDeed()
		{
			Name = "stonevilla2";
		}

		public stonevilla2AddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}