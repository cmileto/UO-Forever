
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
	public class CustomPubInnAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {68, -7, -7, 0}, {54, -7, -7, 5}, {9, -7, -7, 27}// 1	2	3	
			, {67, -7, -6, 0}, {58, -7, -6, 5}, {84, -7, -6, 25}// 4	5	6	
			, {8, -7, -6, 27}, {67, -7, -5, 0}, {84, -7, -5, 25}// 7	8	10	
			, {8, -7, -5, 27}, {67, -7, -4, 0}, {84, -7, -4, 25}// 11	12	14	
			, {8, -7, -4, 27}, {67, -7, -3, 0}, {56, -7, -3, 5}// 15	16	17	
			, {84, -7, -3, 25}, {8, -7, -3, 27}, {66, -6, -7, 0}// 18	19	20	
			, {57, -6, -7, 5}, {83, -6, -7, 25}, {7, -6, -7, 27}// 21	22	23	
			, {1315, -6, -6, 5}, {2912, -6, -6, 5}, {1204, -6, -6, 25}// 24	25	26	
			, {1194, -6, -6, 47}, {2659, -6, -6, 25}, {1791, -6, -6, 47}// 27	28	29	
			, {1315, -6, -5, 5}, {2913, -6, -5, 5}, {1197, -6, -5, 25}// 30	31	32	
			, {1194, -6, -5, 47}, {2652, -6, -5, 25}, {8683, -6, -5, 47}// 33	34	35	
			, {1316, -6, -4, 5}, {2911, -6, -4, 5}, {1197, -6, -4, 25}// 36	37	38	
			, {1194, -6, -4, 47}, {8683, -6, -4, 47}, {1316, -6, -3, 5}// 39	40	41	
			, {1197, -6, -3, 25}, {1194, -6, -3, 47}, {2643, -6, -3, 25}// 42	43	44	
			, {8683, -6, -3, 47}, {66, -5, -7, 0}, {83, -5, -7, 25}// 45	46	48	
			, {7, -5, -7, 27}, {1315, -5, -6, 5}, {2934, -5, -6, 5}// 49	50	51	
			, {1200, -5, -6, 25}, {1194, -5, -6, 47}, {1473, -5, -6, 47}// 52	53	54	
			, {1315, -5, -5, 5}, {2938, -5, -5, 5}, {1195, -5, -5, 25}// 55	56	57	
			, {1194, -5, -5, 47}, {1791, -5, -5, 50}, {1316, -5, -4, 5}// 58	59	61	
			, {2933, -5, -4, 5}, {1194, -5, -4, 25}, {1194, -5, -4, 47}// 62	63	64	
			, {1461, -5, -4, 50}, {1316, -5, -3, 5}, {1194, -5, -3, 25}// 65	66	67	
			, {1194, -5, -3, 47}, {1461, -5, -3, 50}, {66, -4, -7, 0}// 68	69	70	
			, {83, -4, -7, 25}, {7, -4, -7, 27}, {1316, -4, -6, 5}// 72	73	74	
			, {2912, -4, -6, 5}, {1200, -4, -6, 25}, {1194, -4, -6, 47}// 75	76	77	
			, {2604, -4, -6, 25}, {1473, -4, -6, 47}, {1316, -4, -5, 5}// 78	79	81	
			, {2913, -4, -5, 5}, {1194, -4, -5, 25}, {1194, -4, -5, 47}// 82	83	84	
			, {1473, -4, -5, 50}, {1316, -4, -4, 5}, {2911, -4, -4, 5}// 85	86	87	
			, {1194, -4, -4, 25}, {1194, -4, -4, 47}, {1791, -4, -4, 53}// 88	89	90	
			, {1316, -4, -3, 5}, {1196, -4, -3, 25}, {1194, -4, -3, 47}// 91	92	93	
			, {1461, -4, -3, 53}, {67, -7, -2, 0}, {53, -7, -2, 5}// 94	95	96	
			, {84, -7, -2, 25}, {13, -7, -2, 27}, {67, -7, -1, 0}// 97	98	99	
			, {53, -7, -1, 5}, {84, -7, -1, 25}, {8, -7, -1, 27}// 100	101	102	
			, {67, -7, 0, 0}, {53, -7, 0, 5}, {84, -7, 0, 25}// 103	104	105	
			, {8, -7, 0, 27}, {67, -7, 1, 0}, {53, -7, 1, 5}// 106	107	108	
			, {84, -7, 1, 25}, {13, -7, 1, 27}, {67, -7, 2, 0}// 109	110	111	
			, {53, -7, 2, 5}, {84, -7, 2, 25}, {8, -7, 2, 27}// 112	113	114	
			, {67, -7, 3, 0}, {53, -7, 3, 5}, {84, -7, 3, 25}// 115	116	117	
			, {8, -7, 3, 27}, {67, -7, 4, 0}, {53, -7, 4, 5}// 118	119	120	
			, {84, -7, 4, 25}, {8, -7, 4, 27}, {67, -7, 5, 0}// 121	122	123	
			, {53, -7, 5, 5}, {84, -7, 5, 25}, {8, -7, 5, 27}// 124	125	126	
			, {67, -7, 6, 0}, {53, -7, 6, 5}, {84, -7, 6, 25}// 127	128	129	
			, {13, -7, 6, 27}, {67, -7, 7, 0}, {53, -7, 7, 5}// 130	131	132	
			, {1315, -6, -2, 5}, {10, -6, -2, 5}, {1202, -6, -2, 25}// 133	134	135	
			, {83, -6, -2, 25}, {7, -6, -2, 27}, {1194, -6, -2, 47}// 136	137	138	
			, {8683, -6, -2, 47}, {1315, -6, -1, 5}, {1848, -6, -1, 5}// 139	140	141	
			, {1848, -6, -1, 10}, {1194, -6, -1, 47}, {8683, -6, -1, 47}// 142	143	144	
			, {1315, -6, 0, 5}, {1848, -6, 0, 5}, {1848, -6, 0, 10}// 145	146	147	
			, {1194, -6, 0, 47}, {8683, -6, 0, 47}, {1316, -6, 1, 5}// 148	149	150	
			, {10, -6, 1, 5}, {1204, -6, 1, 25}, {83, -6, 1, 25}// 151	152	153	
			, {7, -6, 1, 27}, {1194, -6, 1, 47}, {8683, -6, 1, 47}// 154	155	156	
			, {1316, -6, 2, 5}, {86, -6, 2, 5}, {86, -6, 2, 8}// 157	158	159	
			, {1309, -6, 2, 12}, {2951, -6, 2, 15}, {2519, -6, 2, 21}// 160	161	162	
			, {2519, -6, 2, 22}, {2519, -6, 2, 23}, {6871, -6, 2, 12}// 163	164	165	
			, {1197, -6, 2, 25}, {1194, -6, 2, 47}, {2639, -6, 2, 25}// 166	167	168	
			, {8683, -6, 2, 47}, {1316, -6, 3, 5}, {86, -6, 3, 5}// 169	170	171	
			, {86, -6, 3, 8}, {1309, -6, 3, 12}, {2951, -6, 3, 15}// 172	173	174	
			, {2528, -6, 3, 21}, {2553, -6, 3, 21}, {2553, -6, 3, 22}// 175	176	177	
			, {2553, -6, 3, 23}, {2451, -6, 3, 12}, {1197, -6, 3, 25}// 178	179	180	
			, {1194, -6, 3, 47}, {8683, -6, 3, 47}, {1316, -6, 4, 5}// 181	182	183	
			, {86, -6, 4, 5}, {85, -6, 4, 5}, {86, -6, 4, 8}// 184	185	186	
			, {1309, -6, 4, 12}, {7711, -6, 4, 12}, {2515, -6, 4, 15}// 187	188	189	
			, {2470, -6, 4, 12}, {4270, -6, 4, 5}, {1197, -6, 4, 25}// 190	191	192	
			, {1194, -6, 4, 47}, {2703, -6, 4, 25}, {8683, -6, 4, 47}// 193	194	195	
			, {1316, -6, 5, 5}, {81, -6, 5, 10}, {2541, -6, 5, 12}// 196	199	200	
			, {3530, -6, 5, 12}, {2416, -6, 5, 18}, {4269, -6, 5, 5}// 201	202	203	
			, {1197, -6, 5, 25}, {1194, -6, 5, 47}, {2702, -6, 5, 25}// 204	205	206	
			, {8683, -6, 5, 47}, {1316, -6, 6, 5}, {85, -6, 6, 5}// 207	208	209	
			, {86, -6, 6, 5}, {79, -6, 6, 10}, {82, -6, 6, 8}// 210	211	212	
			, {83, -6, 6, 10}, {1309, -6, 6, 12}, {2520, -6, 6, 12}// 213	214	215	
			, {4268, -6, 6, 5}, {1197, -6, 6, 25}, {83, -6, 6, 25}// 216	217	218	
			, {7, -6, 6, 27}, {1194, -6, 6, 47}, {8683, -6, 6, 47}// 219	220	221	
			, {1316, -6, 7, 5}, {66, -6, 7, 0}, {57, -6, 7, 5}// 222	223	224	
			, {3136, -6, 7, 11}, {1202, -6, 7, 25}, {1790, -6, 7, 28}// 225	226	227	
			, {1790, -6, 7, 47}, {1472, -6, 8, 25}, {1315, -5, -2, 5}// 228	229	230	
			, {7, -5, -2, 5}, {1198, -5, -2, 25}, {83, -5, -2, 25}// 231	232	233	
			, {7, -5, -2, 27}, {1194, -5, -2, 47}, {1461, -5, -2, 50}// 234	235	236	
			, {1315, -5, -1, 5}, {1848, -5, -1, 5}, {1848, -5, -1, 10}// 237	238	239	
			, {1852, -5, -1, 15}, {1194, -5, -1, 47}, {1461, -5, -1, 50}// 240	241	242	
			, {1315, -5, 0, 5}, {1848, -5, 0, 5}, {1850, -5, 0, 10}// 243	244	245	
			, {1194, -5, 0, 47}, {1461, -5, 0, 50}, {1316, -5, 1, 5}// 246	247	248	
			, {7, -5, 1, 5}, {1200, -5, 1, 25}, {83, -5, 1, 25}// 249	250	251	
			, {7, -5, 1, 27}, {1194, -5, 1, 47}, {1461, -5, 1, 50}// 252	253	254	
			, {1316, -5, 2, 5}, {3129, -5, 2, 5}, {3129, -5, 2, 8}// 255	256	257	
			, {5994, -5, 2, 22}, {1194, -5, 2, 25}, {1194, -5, 2, 47}// 258	259	260	
			, {1461, -5, 2, 50}, {1316, -5, 3, 5}, {1194, -5, 3, 25}// 261	262	263	
			, {1194, -5, 3, 47}, {1461, -5, 3, 50}, {1316, -5, 4, 5}// 264	265	266	
			, {1194, -5, 4, 25}, {1194, -5, 4, 47}, {2701, -5, 4, 25}// 267	268	269	
			, {1461, -5, 4, 50}, {1316, -5, 5, 5}, {1194, -5, 5, 25}// 270	271	272	
			, {1194, -5, 5, 47}, {2700, -5, 5, 25}, {1461, -5, 5, 50}// 273	274	275	
			, {1316, -5, 6, 5}, {1194, -5, 6, 25}, {83, -5, 6, 25}// 276	277	278	
			, {7, -5, 6, 27}, {1194, -5, 6, 47}, {1790, -5, 6, 50}// 279	280	281	
			, {1316, -5, 7, 5}, {66, -5, 7, 0}, {1198, -5, 7, 25}// 282	283	285	
			, {1472, -5, 7, 28}, {8685, -5, 7, 27}, {1472, -5, 7, 47}// 286	287	288	
			, {1472, -5, 8, 25}, {1316, -4, -2, 5}, {7, -4, -2, 5}// 289	290	291	
			, {1198, -4, -2, 25}, {83, -4, -2, 25}, {7, -4, -2, 27}// 292	293	294	
			, {1194, -4, -2, 47}, {1461, -4, -2, 53}, {1316, -4, -1, 5}// 295	296	297	
			, {1848, -4, -1, 5}, {1848, -4, -1, 10}, {1848, -4, -1, 15}// 298	299	300	
			, {1852, -4, -1, 20}, {1194, -4, -1, 47}, {1461, -4, -1, 53}// 301	302	303	
			, {1316, -4, 0, 5}, {1850, -4, 0, 5}, {1194, -4, 0, 47}// 304	305	306	
			, {1461, -4, 0, 53}, {1316, -4, 1, 5}, {7, -4, 1, 5}// 307	308	309	
			, {1200, -4, 1, 25}, {83, -4, 1, 25}, {7, -4, 1, 27}// 310	311	312	
			, {1194, -4, 1, 47}, {1461, -4, 1, 53}, {1316, -4, 2, 5}// 313	314	315	
			, {21, -4, 2, 5}, {2938, -4, 2, 7}, {6467, -4, 2, 8}// 316	317	318	
			, {3129, -4, 2, 5}, {3129, -4, 2, 8}, {5995, -4, 2, 21}// 319	320	321	
			, {1195, -4, 2, 25}, {1194, -4, 2, 47}, {2621, -4, 2, 25}// 322	323	324	
			, {1461, -4, 2, 53}, {1316, -4, 3, 5}, {21, -4, 3, 5}// 325	327	328	
			, {2938, -4, 3, 7}, {1194, -4, 3, 25}, {1194, -4, 3, 47}// 329	330	331	
			, {1461, -4, 3, 53}, {1316, -4, 4, 5}, {20, -4, 4, 5}// 332	333	334	
			, {2939, -4, 4, 7}, {1194, -4, 4, 25}, {1194, -4, 4, 47}// 335	336	337	
			, {1461, -4, 4, 53}, {1316, -4, 5, 5}, {1195, -4, 5, 25}// 338	339	340	
			, {1194, -4, 5, 47}, {1790, -4, 5, 53}, {1316, -4, 6, 5}// 341	342	343	
			, {1194, -4, 6, 25}, {83, -4, 6, 25}, {12, -4, 6, 27}// 344	345	346	
			, {1194, -4, 6, 47}, {1472, -4, 6, 50}, {1316, -4, 7, 5}// 347	348	349	
			, {66, -4, 7, 0}, {1198, -4, 7, 25}, {84, -4, 7, 25}// 350	352	353	
			, {8, -4, 7, 27}, {1789, -4, 7, 27}, {8685, -4, 7, 47}// 354	355	356	
			, {1472, -4, 8, 25}, {66, -3, -7, 0}, {55, -3, -7, 5}// 357	358	359	
			, {83, -3, -7, 25}, {7, -3, -7, 27}, {1316, -3, -6, 5}// 360	361	362	
			, {1200, -3, -6, 25}, {1194, -3, -6, 47}, {2666, -3, -6, 25}// 363	364	365	
			, {1473, -3, -6, 47}, {1316, -3, -5, 5}, {1194, -3, -5, 25}// 366	367	368	
			, {1194, -3, -5, 47}, {1473, -3, -5, 50}, {1316, -3, -4, 5}// 369	370	371	
			, {1194, -3, -4, 25}, {1194, -3, -4, 47}, {1473, -3, -4, 53}// 372	373	374	
			, {1316, -3, -3, 5}, {1194, -3, -3, 25}, {1194, -3, -3, 47}// 375	376	377	
			, {1791, -3, -3, 56}, {66, -2, -7, 0}, {57, -2, -7, 5}// 378	379	380	
			, {83, -2, -7, 25}, {7, -2, -7, 27}, {1316, -2, -6, 5}// 381	382	383	
			, {2918, -2, -6, 5}, {1200, -2, -6, 25}, {1194, -2, -6, 47}// 384	385	386	
			, {2667, -2, -6, 25}, {1473, -2, -6, 47}, {1315, -2, -5, 5}// 387	388	389	
			, {2953, -2, -5, 5}, {1194, -2, -5, 25}, {1194, -2, -5, 47}// 390	391	392	
			, {1473, -2, -5, 50}, {1315, -2, -4, 5}, {2918, -2, -4, 5}// 393	394	395	
			, {1196, -2, -4, 25}, {1194, -2, -4, 47}, {1473, -2, -4, 53}// 396	397	398	
			, {1315, -2, -3, 5}, {1194, -2, -3, 25}, {1194, -2, -3, 47}// 399	400	401	
			, {1792, -2, -3, 56}, {66, -1, -7, 0}, {83, -1, -7, 25}// 402	403	405	
			, {7, -1, -7, 27}, {1316, -1, -6, 5}, {2917, -1, -6, 5}// 406	407	408	
			, {1200, -1, -6, 25}, {1194, -1, -6, 47}, {1473, -1, -6, 47}// 409	410	411	
			, {1315, -1, -5, 5}, {2952, -1, -5, 5}, {1195, -1, -5, 25}// 412	413	414	
			, {1194, -1, -5, 47}, {1473, -1, -5, 50}, {1315, -1, -4, 5}// 415	416	418	
			, {2917, -1, -4, 5}, {1194, -1, -4, 25}, {1194, -1, -4, 47}// 419	420	421	
			, {1792, -1, -4, 53}, {1315, -1, -3, 5}, {1196, -1, -3, 25}// 422	423	424	
			, {1194, -1, -3, 47}, {1460, -1, -3, 53}, {66, 0, -7, 0}// 425	426	427	
			, {83, 0, -7, 25}, {12, 0, -7, 27}, {1316, 0, -6, 5}// 429	430	431	
			, {1200, 0, -6, 25}, {84, 0, -6, 25}, {8, 0, -6, 27}// 432	433	434	
			, {1194, 0, -6, 47}, {1473, 0, -6, 47}, {1316, 0, -5, 5}// 435	436	437	
			, {1194, 0, -5, 25}, {84, 0, -5, 25}, {13, 0, -5, 27}// 438	439	440	
			, {1194, 0, -5, 47}, {1792, 0, -5, 50}, {1316, 0, -4, 5}// 441	442	443	
			, {1194, 0, -4, 25}, {1194, 0, -4, 47}, {1460, 0, -4, 50}// 444	445	446	
			, {1316, 0, -3, 5}, {1194, 0, -3, 25}, {9, 0, -3, 27}// 447	448	449	
			, {1194, 0, -3, 47}, {1460, 0, -3, 50}, {66, 1, -7, 0}// 450	451	452	
			, {55, 1, -7, 5}, {1316, 1, -6, 5}, {67, 1, -6, 0}// 453	454	455	
			, {58, 1, -6, 5}, {1203, 1, -6, 25}, {1792, 1, -6, 28}// 456	457	458	
			, {1792, 1, -6, 27}, {1792, 1, -6, 47}, {1316, 1, -5, 5}// 459	460	461	
			, {67, 1, -5, 0}, {1199, 1, -5, 25}, {83, 1, -5, 25}// 462	464	465	
			, {7, 1, -5, 27}, {1789, 1, -5, 27}, {8681, 1, -5, 47}// 466	467	468	
			, {1316, 1, -4, 5}, {67, 1, -4, 0}, {1199, 1, -4, 25}// 469	470	472	
			, {84, 1, -4, 25}, {1194, 1, -4, 47}, {1463, 1, -4, 47}// 473	475	476	
			, {1316, 1, -3, 5}, {67, 1, -3, 0}, {56, 1, -3, 5}// 477	478	479	
			, {1199, 1, -3, 25}, {82, 1, -3, 25}, {7, 1, -3, 27}// 480	481	482	
			, {1194, 1, -3, 47}, {1471, 1, -3, 50}, {71, 2, -7, 2}// 484	485	486	
			, {83, 2, -7, 0}, {83, 2, -7, 22}, {1460, 2, -6, 25}// 487	488	489	
			, {3309, 2, -6, 0}, {1460, 2, -5, 25}, {1460, 2, -4, 25}// 490	491	492	
			, {1792, 2, -4, 47}, {3766, 2, -4, 0}, {7608, 2, -4, 4}// 493	494	495	
			, {1460, 2, -3, 25}, {8681, 2, -3, 47}, {2602, 2, -3, 0}// 497	498	499	
			, {3312, 2, -3, 0}, {83, 3, -7, 0}, {80, 3, -7, 22}// 500	501	502	
			, {1471, 3, -6, 24}, {2602, 3, -4, 0}, {72, 4, -7, 2}// 503	504	505	
			, {83, 4, -7, 0}, {78, 4, -7, 22}, {1471, 4, -6, 24}// 506	507	508	
			, {83, 5, -7, 0}, {71, 5, -7, 2}, {83, 5, -7, 22}// 509	510	511	
			, {1471, 5, -6, 24}, {2602, 5, -6, 0}, {3766, 5, -5, 0}// 512	513	514	
			, {7608, 5, -5, 4}, {2602, 5, -4, 0}, {83, 6, -7, 0}// 515	517	518	
			, {80, 6, -7, 22}, {1471, 6, -6, 24}, {72, 7, -7, 2}// 519	520	521	
			, {83, 7, -7, 0}, {78, 7, -7, 22}, {73, 7, -6, 2}// 522	523	524	
			, {84, 7, -6, 0}, {84, 7, -6, 22}, {1471, 7, -6, 24}// 525	526	527	
			, {84, 7, -5, 0}, {81, 7, -5, 22}, {84, 7, -4, 0}// 528	529	530	
			, {70, 7, -4, 2}, {79, 7, -4, 22}, {73, 7, -3, 2}// 531	532	533	
			, {84, 7, -3, 0}, {84, 7, -3, 22}, {1466, 8, -6, 21}// 534	535	536	
			, {1459, 8, -5, 24}, {1459, 8, -4, 24}, {1459, 8, -3, 24}// 537	538	539	
			, {1316, -3, -2, 5}, {12, -3, -2, 5}, {1194, -3, -2, 25}// 540	541	542	
			, {83, -3, -2, 25}, {12, -3, -2, 27}, {1194, -3, -2, 47}// 543	544	545	
			, {8683, -3, -2, 56}, {1316, -3, -1, 5}, {13, -3, -1, 5}// 546	547	548	
			, {1197, -3, -1, 25}, {1194, -3, -1, 47}, {8683, -3, -1, 56}// 549	550	551	
			, {1316, -3, 0, 5}, {1197, -3, 0, 25}, {1194, -3, 0, 47}// 552	553	554	
			, {2240, -3, 0, 25}, {2237, -3, 0, 25}, {8683, -3, 0, 56}// 555	556	557	
			, {1316, -3, 1, 5}, {11, -3, 1, 5}, {12, -3, 1, 5}// 558	559	560	
			, {1194, -3, 1, 25}, {83, -3, 1, 25}, {12, -3, 1, 27}// 561	562	563	
			, {1194, -3, 1, 47}, {2237, -3, 1, 25}, {8683, -3, 1, 56}// 564	565	566	
			, {1316, -3, 2, 5}, {2602, -3, 2, 5}, {1194, -3, 2, 25}// 567	568	569	
			, {1194, -3, 2, 47}, {2620, -3, 2, 25}, {8683, -3, 2, 56}// 570	571	572	
			, {1316, -3, 3, 5}, {2602, -3, 3, 5}, {1194, -3, 3, 25}// 573	574	575	
			, {1194, -3, 3, 47}, {2905, -3, 3, 25}, {8683, -3, 3, 56}// 576	577	578	
			, {1316, -3, 4, 5}, {2602, -3, 4, 5}, {1194, -3, 4, 25}// 579	580	581	
			, {1194, -3, 4, 47}, {1790, -3, 4, 56}, {1316, -3, 5, 5}// 582	583	584	
			, {1194, -3, 5, 25}, {1194, -3, 5, 47}, {1472, -3, 5, 53}// 585	586	587	
			, {1316, -3, 6, 5}, {1194, -3, 6, 25}, {1194, -3, 6, 47}// 588	589	590	
			, {1472, -3, 6, 50}, {1316, -3, 7, 5}, {66, -3, 7, 0}// 591	592	593	
			, {55, -3, 7, 5}, {1198, -3, 7, 25}, {83, -3, 7, 25}// 594	595	596	
			, {1194, -3, 7, 47}, {1462, -3, 7, 47}, {1472, -3, 8, 25}// 598	599	600	
			, {1790, -3, 8, 47}, {1315, -2, -2, 5}, {2780, -2, -2, 6}// 601	602	603	
			, {1194, -2, -2, 25}, {1194, -2, -2, 47}, {8681, -2, -2, 56}// 604	605	606	
			, {1316, -2, -1, 5}, {2783, -2, -1, 6}, {1194, -2, -1, 25}// 607	608	609	
			, {1194, -2, -1, 47}, {8681, -2, -1, 56}, {1316, -2, 0, 5}// 610	611	613	
			, {2783, -2, 0, 6}, {1195, -2, 0, 25}, {1194, -2, 0, 47}// 614	615	616	
			, {8681, -2, 0, 56}, {1316, -2, 1, 5}, {2783, -2, 1, 6}// 617	618	619	
			, {1194, -2, 1, 25}, {1194, -2, 1, 47}, {8681, -2, 1, 56}// 620	621	622	
			, {1316, -2, 2, 5}, {2783, -2, 2, 6}, {1194, -2, 2, 25}// 624	625	626	
			, {1194, -2, 2, 47}, {8681, -2, 2, 56}, {1316, -2, 3, 5}// 627	628	629	
			, {2783, -2, 3, 6}, {1196, -2, 3, 25}, {1194, -2, 3, 47}// 630	631	632	
			, {8681, -2, 3, 56}, {1316, -2, 4, 5}, {2783, -2, 4, 6}// 633	634	635	
			, {1194, -2, 4, 25}, {1194, -2, 4, 47}, {1789, -2, 4, 56}// 636	637	638	
			, {1316, -2, 5, 5}, {2781, -2, 5, 6}, {1194, -2, 5, 25}// 639	640	641	
			, {1194, -2, 5, 47}, {1472, -2, 5, 53}, {1316, -2, 6, 5}// 642	643	644	
			, {1194, -2, 6, 25}, {9, -2, 6, 27}, {1194, -2, 6, 47}// 645	646	647	
			, {1472, -2, 6, 50}, {1316, -2, 7, 5}, {66, -2, 7, 0}// 648	649	650	
			, {57, -2, 7, 5}, {1198, -2, 7, 25}, {82, -2, 7, 25}// 651	652	653	
			, {8, -2, 7, 27}, {1194, -2, 7, 47}, {1459, -2, 7, 50}// 654	656	657	
			, {1472, -2, 8, 25}, {1472, -2, 8, 47}, {1315, -1, -2, 5}// 658	659	660	
			, {2784, -1, -2, 6}, {1194, -1, -2, 25}, {83, -1, -2, 25}// 661	662	663	
			, {10, -1, -2, 27}, {1194, -1, -2, 47}, {1460, -1, -2, 53}// 664	665	666	
			, {1315, -1, -1, 5}, {2778, -1, -1, 6}, {1196, -1, -1, 25}// 667	668	669	
			, {1194, -1, -1, 47}, {1460, -1, -1, 53}, {1315, -1, 0, 5}// 670	671	672	
			, {2778, -1, 0, 6}, {1194, -1, 0, 25}, {1194, -1, 0, 47}// 673	674	675	
			, {1460, -1, 0, 53}, {1315, -1, 1, 5}, {2778, -1, 1, 6}// 676	677	678	
			, {1194, -1, 1, 25}, {83, -1, 1, 25}, {10, -1, 1, 27}// 679	680	681	
			, {1194, -1, 1, 47}, {1460, -1, 1, 53}, {1315, -1, 2, 5}// 682	683	684	
			, {2778, -1, 2, 6}, {1194, -1, 2, 25}, {1194, -1, 2, 47}// 685	686	687	
			, {2604, -1, 2, 25}, {1460, -1, 2, 53}, {1316, -1, 3, 5}// 688	689	690	
			, {2778, -1, 3, 6}, {1194, -1, 3, 25}, {1194, -1, 3, 47}// 691	692	693	
			, {1460, -1, 3, 53}, {1316, -1, 4, 5}, {2778, -1, 4, 6}// 694	695	696	
			, {1194, -1, 4, 25}, {1194, -1, 4, 47}, {1460, -1, 4, 53}// 697	698	699	
			, {1315, -1, 5, 5}, {2786, -1, 5, 6}, {1194, -1, 5, 25}// 700	701	702	
			, {1194, -1, 5, 47}, {1789, -1, 5, 53}, {1315, -1, 6, 5}// 703	704	705	
			, {1196, -1, 6, 25}, {83, -1, 6, 25}, {7, -1, 6, 27}// 706	707	708	
			, {1194, -1, 6, 47}, {1472, -1, 6, 50}, {1315, -1, 7, 5}// 709	710	711	
			, {66, -1, 7, 0}, {1198, -1, 7, 25}, {1790, -1, 7, 28}// 712	714	715	
			, {1465, -1, 7, 47}, {1472, -1, 8, 25}, {1789, -1, 8, 47}// 716	717	718	
			, {1315, 0, -2, 5}, {2782, 0, -2, 6}, {1194, 0, -2, 25}// 719	720	721	
			, {82, 0, -2, 25}, {6, 0, -2, 27}, {1194, 0, -2, 47}// 722	723	724	
			, {1460, 0, -2, 50}, {1315, 0, -1, 5}, {2785, 0, -1, 6}// 725	726	727	
			, {1194, 0, -1, 25}, {84, 0, -1, 25}, {8, 0, -1, 27}// 728	729	730	
			, {1194, 0, -1, 47}, {1460, 0, -1, 50}, {1315, 0, 0, 5}// 731	732	733	
			, {2785, 0, 0, 6}, {1194, 0, 0, 25}, {84, 0, 0, 25}// 734	735	736	
			, {8, 0, 0, 27}, {1194, 0, 0, 47}, {1460, 0, 0, 50}// 737	738	739	
			, {1315, 0, 1, 5}, {2785, 0, 1, 6}, {1196, 0, 1, 25}// 740	741	742	
			, {82, 0, 1, 25}, {6, 0, 1, 27}, {1194, 0, 1, 47}// 743	744	745	
			, {1460, 0, 1, 50}, {1315, 0, 2, 5}, {2785, 0, 2, 6}// 746	747	748	
			, {1196, 0, 2, 25}, {84, 0, 2, 25}, {13, 0, 2, 27}// 749	750	751	
			, {1194, 0, 2, 47}, {1460, 0, 2, 50}, {1316, 0, 3, 5}// 752	753	754	
			, {2785, 0, 3, 6}, {1196, 0, 3, 25}, {1194, 0, 3, 47}// 755	756	757	
			, {1460, 0, 3, 50}, {1316, 0, 4, 5}, {2785, 0, 4, 6}// 758	759	760	
			, {1194, 0, 4, 25}, {9, 0, 4, 27}, {1194, 0, 4, 47}// 761	762	763	
			, {1460, 0, 4, 50}, {1315, 0, 5, 5}, {2779, 0, 5, 6}// 764	765	766	
			, {1194, 0, 5, 25}, {84, 0, 5, 25}, {8, 0, 5, 27}// 767	768	769	
			, {1194, 0, 5, 47}, {1460, 0, 5, 50}, {1315, 0, 6, 5}// 770	771	772	
			, {1194, 0, 6, 25}, {82, 0, 6, 25}, {6, 0, 6, 27}// 773	774	775	
			, {1194, 0, 6, 47}, {1789, 0, 6, 50}, {1315, 0, 7, 5}// 776	777	778	
			, {66, 0, 7, 0}, {1198, 0, 7, 25}, {1472, 0, 7, 28}// 779	781	782	
			, {1472, 0, 7, 47}, {1472, 0, 8, 25}, {1315, 1, -2, 5}// 783	784	785	
			, {67, 1, -2, 0}, {53, 1, -2, 5}, {1199, 1, -2, 25}// 786	787	788	
			, {1792, 1, -2, 28}, {1465, 1, -2, 47}, {1315, 1, -1, 5}// 789	790	791	
			, {67, 1, -1, 0}, {58, 1, -1, 5}, {1199, 1, -1, 25}// 792	793	794	
			, {1460, 1, -1, 28}, {8681, 1, -1, 47}, {1315, 1, 0, 5}// 795	796	797	
			, {67, 1, 0, 0}, {1199, 1, 0, 25}, {1460, 1, 0, 28}// 798	799	800	
			, {8681, 1, 0, 47}, {1315, 1, 1, 5}, {67, 1, 1, 0}// 801	802	803	
			, {56, 1, 1, 5}, {1199, 1, 1, 25}, {1460, 1, 1, 28}// 804	805	806	
			, {8681, 1, 1, 27}, {8681, 1, 1, 47}, {1315, 1, 2, 5}// 807	808	809	
			, {67, 1, 2, 0}, {53, 1, 2, 5}, {1199, 1, 2, 25}// 810	811	812	
			, {83, 1, 2, 25}, {7, 1, 2, 27}, {1789, 1, 2, 27}// 813	814	815	
			, {8681, 1, 2, 47}, {1316, 1, 3, 5}, {67, 1, 3, 0}// 816	817	818	
			, {53, 1, 3, 5}, {1199, 1, 3, 25}, {84, 1, 3, 25}// 819	820	821	
			, {1194, 1, 3, 47}, {1463, 1, 3, 47}, {1316, 1, 4, 5}// 823	824	825	
			, {67, 1, 4, 0}, {58, 1, 4, 5}, {1199, 1, 4, 25}// 826	827	828	
			, {82, 1, 4, 25}, {7, 1, 4, 27}, {1194, 1, 4, 47}// 829	830	832	
			, {1471, 1, 4, 50}, {1315, 1, 5, 5}, {67, 1, 5, 0}// 833	834	835	
			, {1199, 1, 5, 25}, {1792, 1, 5, 28}, {1465, 1, 5, 47}// 836	837	838	
			, {1315, 1, 6, 5}, {67, 1, 6, 0}, {56, 1, 6, 5}// 839	840	841	
			, {1199, 1, 6, 25}, {1460, 1, 6, 28}, {8681, 1, 6, 47}// 842	843	844	
			, {1315, 1, 7, 5}, {65, 1, 7, 0}, {55, 1, 7, 5}// 845	846	847	
			, {53, 1, 7, 5}, {1201, 1, 7, 25}, {1789, 1, 7, 28}// 848	849	850	
			, {1789, 1, 7, 47}, {1472, 1, 8, 25}, {3310, 1, 8, 0}// 851	852	853	
			, {1460, 2, -2, 25}, {1789, 2, -2, 47}, {3311, 2, -2, 0}// 854	855	856	
			, {1855, 2, -1, 0}, {1460, 2, -1, 25}, {1850, 2, 0, 0}// 857	858	859	
			, {1460, 2, 0, 25}, {1854, 2, 1, 0}, {1460, 2, 1, 25}// 860	861	862	
			, {71, 2, 2, 2}, {83, 2, 2, 0}, {83, 2, 2, 22}// 863	864	865	
			, {1460, 2, 2, 25}, {1460, 2, 3, 25}, {1792, 2, 3, 47}// 866	867	868	
			, {3309, 2, 3, 0}, {1855, 2, 4, 0}, {1460, 2, 4, 25}// 869	870	871	
			, {8681, 2, 4, 47}, {1850, 2, 5, 0}, {1460, 2, 5, 25}// 872	873	874	
			, {1789, 2, 5, 47}, {1854, 2, 6, 0}, {1460, 2, 6, 25}// 875	876	877	
			, {1460, 2, 7, 25}, {1789, 2, 8, 25}, {83, 3, 2, 0}// 878	879	880	
			, {80, 3, 2, 22}, {1471, 3, 3, 24}, {3766, 4, -1, 0}// 881	882	883	
			, {7608, 4, -1, 4}, {2602, 4, 0, 0}, {72, 4, 2, 2}// 884	886	887	
			, {83, 4, 2, 0}, {78, 4, 2, 22}, {1471, 4, 3, 24}// 888	889	890	
			, {2602, 5, -1, 0}, {71, 5, 2, 2}, {83, 5, 2, 0}// 891	892	893	
			, {83, 5, 2, 22}, {1471, 5, 3, 24}, {83, 6, 2, 0}// 894	895	896	
			, {80, 6, 2, 22}, {1471, 6, 3, 24}, {84, 7, -2, 0}// 897	898	899	
			, {81, 7, -2, 22}, {84, 7, -1, 0}, {70, 7, -1, 2}// 900	901	902	
			, {79, 7, -1, 22}, {73, 7, 0, 2}, {84, 7, 0, 0}// 903	904	905	
			, {84, 7, 0, 22}, {84, 7, 1, 0}, {81, 7, 1, 22}// 906	907	908	
			, {69, 7, 2, 2}, {82, 7, 2, 0}, {79, 7, 2, 22}// 909	910	911	
			, {78, 7, 2, 22}, {1471, 7, 3, 24}, {1459, 8, -2, 24}// 912	913	914	
			, {1459, 8, -1, 24}, {1459, 8, 0, 24}, {1459, 8, 1, 24}// 915	916	917	
			, {1459, 8, 2, 24}, {3314, 8, 2, 0}, {1466, 8, 3, 21}// 918	919	920	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CustomPubInnAddonDeed();
			}
		}

		[ Constructable ]
		public CustomPubInnAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 15, -7, -5, 5, 0, 0, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 15, -7, -4, 5, 0, 0, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 14, -5, -7, 5, 0, 0, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 2575, -5, -5, 13, 0, 0, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 14, -4, -7, 5, 0, 0, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 2562, -4, -6, 38, 0, 0, "", 1);// 80
			AddComplexComponent( (BaseAddon) this, 4012, -6, 5, 5, 0, 0, "", 1);// 197
			AddComplexComponent( (BaseAddon) this, 3555, -6, 5, 6, 0, 0, "", 1);// 198
			AddComplexComponent( (BaseAddon) this, 14, -5, 7, 5, 0, 0, "", 1);// 284
			AddComplexComponent( (BaseAddon) this, 2562, -4, 2, 36, 0, 0, "", 1);// 326
			AddComplexComponent( (BaseAddon) this, 14, -4, 7, 5, 0, 0, "", 1);// 351
			AddComplexComponent( (BaseAddon) this, 14, -1, -7, 5, 0, 0, "", 1);// 404
			AddComplexComponent( (BaseAddon) this, 2575, -1, -5, 13, 0, 0, "", 1);// 417
			AddComplexComponent( (BaseAddon) this, 14, 0, -7, 5, 0, 0, "", 1);// 428
			AddComplexComponent( (BaseAddon) this, 15, 1, -5, 5, 0, 0, "", 1);// 463
			AddComplexComponent( (BaseAddon) this, 15, 1, -4, 5, 0, 0, "", 1);// 471
			AddComplexComponent( (BaseAddon) this, 15, 1, -4, 27, 0, 0, "", 1);// 474
			AddComplexComponent( (BaseAddon) this, 15, 1, -3, 27, 0, 0, "", 1);// 483
			AddComplexComponent( (BaseAddon) this, 2575, 2, -4, 7, 0, 0, "", 1);// 496
			AddComplexComponent( (BaseAddon) this, 2575, 5, -5, 7, 0, 0, "", 1);// 516
			AddComplexComponent( (BaseAddon) this, 14, -3, 7, 27, 0, 0, "", 1);// 597
			AddComplexComponent( (BaseAddon) this, 2557, -2, -1, 17, 0, 0, "", 1);// 612
			AddComplexComponent( (BaseAddon) this, 2557, -2, 1, 17, 0, 0, "", 1);// 623
			AddComplexComponent( (BaseAddon) this, 14, -2, 7, 27, 0, 0, "", 1);// 655
			AddComplexComponent( (BaseAddon) this, 14, -1, 7, 5, 0, 0, "", 1);// 713
			AddComplexComponent( (BaseAddon) this, 14, 0, 7, 5, 0, 0, "", 1);// 780
			AddComplexComponent( (BaseAddon) this, 15, 1, 3, 27, 0, 0, "", 1);// 822
			AddComplexComponent( (BaseAddon) this, 15, 1, 4, 27, 0, 0, "", 1);// 831
			AddComplexComponent( (BaseAddon) this, 2575, 4, -1, 7, 0, 0, "", 1);// 885

		}

		public CustomPubInnAddon( Serial serial ) : base( serial )
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

	public class CustomPubInnAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CustomPubInnAddon();
			}
		}

		[Constructable]
		public CustomPubInnAddonDeed()
		{
			Name = "CustomPubInn";
		}

		public CustomPubInnAddonDeed( Serial serial ) : base( serial )
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