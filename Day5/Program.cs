﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Day3
{
    class Program
    {
        static void Main()
        {
            // string input = System.IO.File.ReadAllText("Input.txt");
            string input =
                "76|18\n58|19\n58|49\n44|59\n44|16\n44|25\n59|33\n59|35\n59|51\n59|71\n79|28\n79|76\n79|18\n79|63\n79|44\n99|85\n99|79\n99|55\n99|36\n99|33\n99|63\n86|73\n86|63\n86|18\n86|48\n86|35\n86|11\n86|57\n98|82\n98|76\n98|35\n98|99\n98|32\n98|79\n98|95\n98|29\n46|48\n46|57\n46|75\n46|49\n46|13\n46|98\n46|93\n46|45\n46|44\n56|17\n56|32\n56|86\n56|53\n56|37\n56|36\n56|55\n56|24\n56|11\n56|85\n85|39\n85|92\n85|84\n85|25\n85|45\n85|54\n85|51\n85|61\n85|78\n85|59\n85|21\n93|99\n93|61\n93|82\n93|21\n93|54\n93|56\n93|92\n93|79\n93|58\n93|33\n93|95\n93|24\n32|57\n32|37\n32|19\n32|44\n32|85\n32|13\n32|28\n32|17\n32|55\n32|48\n32|53\n32|78\n32|11\n35|32\n35|92\n35|33\n35|28\n35|79\n35|56\n35|36\n35|54\n35|61\n35|19\n35|71\n35|13\n35|24\n35|16\n45|76\n45|32\n45|71\n45|79\n45|58\n45|24\n45|99\n45|42\n45|51\n45|54\n45|82\n45|29\n45|25\n45|33\n45|84\n37|59\n37|75\n37|86\n37|39\n37|63\n37|57\n37|93\n37|44\n37|11\n37|42\n37|85\n37|18\n37|16\n37|53\n37|36\n37|48\n18|61\n18|21\n18|51\n18|84\n18|73\n18|17\n18|45\n18|39\n18|35\n18|59\n18|48\n18|31\n18|53\n18|54\n18|75\n18|71\n18|25\n13|75\n13|78\n13|86\n13|45\n13|85\n13|59\n13|21\n13|82\n13|39\n13|63\n13|18\n13|17\n13|11\n13|93\n13|44\n13|98\n13|42\n13|31\n53|54\n53|42\n53|75\n53|35\n53|21\n53|31\n53|71\n53|79\n53|99\n53|92\n53|58\n53|98\n53|51\n53|25\n53|45\n53|84\n53|93\n53|61\n53|82\n63|31\n63|59\n63|61\n63|75\n63|25\n63|82\n63|51\n63|35\n63|93\n63|17\n63|84\n63|54\n63|98\n63|42\n63|45\n63|11\n63|48\n63|73\n63|21\n63|39\n42|35\n42|95\n42|54\n42|56\n42|19\n42|33\n42|92\n42|71\n42|24\n42|32\n42|76\n42|51\n42|21\n42|49\n42|55\n42|79\n42|29\n42|58\n42|61\n42|28\n42|25\n29|63\n29|32\n29|76\n29|85\n29|44\n29|19\n29|86\n29|16\n29|49\n29|95\n29|18\n29|37\n29|57\n29|28\n29|55\n29|79\n29|36\n29|11\n29|13\n29|46\n29|24\n29|48\n19|49\n19|31\n19|18\n19|75\n19|73\n19|13\n19|16\n19|44\n19|53\n19|86\n19|36\n19|48\n19|63\n19|39\n19|98\n19|78\n19|46\n19|85\n19|57\n19|37\n19|11\n19|17\n19|59\n51|36\n51|79\n51|92\n51|24\n51|71\n51|54\n51|19\n51|33\n51|61\n51|37\n51|29\n51|44\n51|28\n51|32\n51|76\n51|99\n51|95\n51|35\n51|46\n51|56\n51|55\n51|13\n51|58\n51|49\n75|71\n75|51\n75|35\n75|42\n75|33\n75|25\n75|82\n75|56\n75|29\n75|99\n75|73\n75|61\n75|79\n75|93\n75|58\n75|59\n75|84\n75|39\n75|31\n75|98\n75|21\n75|45\n75|92\n75|54\n54|32\n54|99\n54|76\n54|55\n54|61\n54|49\n54|29\n54|28\n54|24\n54|33\n54|13\n54|46\n54|79\n54|95\n54|86\n54|37\n54|36\n54|19\n54|56\n54|71\n54|92\n54|58\n54|44\n54|16\n78|99\n78|92\n78|75\n78|71\n78|29\n78|59\n78|93\n78|25\n78|33\n78|45\n78|51\n78|21\n78|61\n78|39\n78|42\n78|58\n78|82\n78|54\n78|73\n78|98\n78|31\n78|53\n78|84\n78|35\n84|56\n84|79\n84|95\n84|32\n84|29\n84|71\n84|36\n84|19\n84|33\n84|24\n84|92\n84|99\n84|54\n84|51\n84|55\n84|37\n84|28\n84|58\n84|13\n84|61\n84|46\n84|35\n84|76\n84|49\n71|76\n71|33\n71|57\n71|36\n71|16\n71|13\n71|99\n71|85\n71|86\n71|19\n71|29\n71|95\n71|58\n71|24\n71|37\n71|32\n71|63\n71|46\n71|28\n71|79\n71|49\n71|44\n71|56\n71|55\n95|63\n95|78\n95|85\n95|57\n95|19\n95|46\n95|44\n95|55\n95|17\n95|48\n95|39\n95|18\n95|11\n95|75\n95|76\n95|86\n95|37\n95|36\n95|53\n95|49\n95|73\n95|28\n95|13\n95|16\n28|48\n28|13\n28|17\n28|36\n28|86\n28|11\n28|55\n28|63\n28|49\n28|37\n28|31\n28|16\n28|44\n28|85\n28|76\n28|53\n28|39\n28|57\n28|19\n28|78\n28|46\n28|73\n28|75\n28|18\n92|56\n92|76\n92|95\n92|33\n92|24\n92|36\n92|63\n92|79\n92|71\n92|32\n92|16\n92|57\n92|37\n92|99\n92|29\n92|46\n92|19\n92|44\n92|58\n92|86\n92|49\n92|55\n92|28\n92|13\n11|84\n11|25\n11|18\n11|73\n11|92\n11|98\n11|61\n11|82\n11|59\n11|35\n11|93\n11|54\n11|45\n11|39\n11|48\n11|75\n11|71\n11|31\n11|17\n11|51\n11|21\n11|78\n11|42\n11|53\n55|49\n55|11\n55|16\n55|76\n55|46\n55|85\n55|37\n55|44\n55|73\n55|36\n55|75\n55|57\n55|63\n55|31\n55|17\n55|86\n55|48\n55|18\n55|39\n55|13\n55|53\n55|78\n55|19\n55|59\n31|51\n31|59\n31|82\n31|95\n31|42\n31|71\n31|25\n31|58\n31|24\n31|45\n31|21\n31|61\n31|84\n31|99\n31|92\n31|56\n31|33\n31|54\n31|79\n31|35\n31|29\n31|93\n31|98\n31|32\n73|54\n73|42\n73|71\n73|84\n73|33\n73|93\n73|24\n73|92\n73|79\n73|99\n73|25\n73|31\n73|82\n73|29\n73|59\n73|21\n73|35\n73|32\n73|56\n73|58\n73|98\n73|45\n73|51\n73|61\n48|53\n48|75\n48|58\n48|78\n48|25\n48|98\n48|45\n48|31\n48|73\n48|59\n48|51\n48|93\n48|17\n48|92\n48|84\n48|54\n48|99\n48|21\n48|61\n48|42\n48|71\n48|39\n48|82\n48|35\n24|85\n24|18\n24|28\n24|13\n24|19\n24|76\n24|36\n24|86\n24|55\n24|46\n24|63\n24|39\n24|95\n24|48\n24|57\n24|53\n24|49\n24|78\n24|37\n24|75\n24|17\n24|11\n24|16\n24|44\n25|76\n25|71\n25|21\n25|92\n25|37\n25|99\n25|33\n25|32\n25|35\n25|49\n25|84\n25|61\n25|54\n25|51\n25|29\n25|79\n25|46\n25|95\n25|24\n25|55\n25|58\n25|19\n25|28\n25|56\n21|37\n21|51\n21|92\n21|33\n21|28\n21|36\n21|95\n21|76\n21|35\n21|58\n21|84\n21|46\n21|61\n21|24\n21|71\n21|49\n21|32\n21|55\n21|79\n21|19\n21|29\n21|54\n21|56\n21|99\n16|84\n16|11\n16|57\n16|42\n16|48\n16|86\n16|53\n16|78\n16|98\n16|39\n16|85\n16|59\n16|82\n16|73\n16|63\n16|75\n16|93\n16|25\n16|18\n16|21\n16|17\n16|45\n16|31\n16|51\n39|61\n39|32\n39|25\n39|98\n39|56\n39|45\n39|92\n39|82\n39|93\n39|99\n39|59\n39|79\n39|51\n39|35\n39|42\n39|29\n39|71\n39|73\n39|33\n39|58\n39|21\n39|54\n39|31\n39|84\n33|79\n33|19\n33|11\n33|56\n33|46\n33|49\n33|28\n33|18\n33|85\n33|55\n33|63\n33|13\n33|44\n33|36\n33|86\n33|48\n33|24\n33|16\n33|57\n33|29\n33|76\n33|95\n33|37\n33|32\n17|84\n17|75\n17|42\n17|99\n17|71\n17|53\n17|33\n17|78\n17|98\n17|31\n17|73\n17|25\n17|39\n17|59\n17|93\n17|82\n17|61\n17|21\n17|35\n17|54\n17|92\n17|51\n17|45\n17|58\n57|53\n57|54\n57|18\n57|42\n57|25\n57|73\n57|59\n57|98\n57|51\n57|48\n57|85\n57|21\n57|39\n57|31\n57|17\n57|45\n57|82\n57|63\n57|84\n57|35\n57|78\n57|11\n57|93\n57|75\n82|56\n82|35\n82|24\n82|76\n82|46\n82|19\n82|79\n82|25\n82|99\n82|84\n82|51\n82|32\n82|28\n82|95\n82|71\n82|21\n82|92\n82|58\n82|61\n82|33\n82|54\n82|42\n82|29\n82|55\n61|79\n61|28\n61|13\n61|19\n61|92\n61|24\n61|36\n61|58\n61|71\n61|29\n61|99\n61|55\n61|33\n61|86\n61|46\n61|49\n61|56\n61|32\n61|57\n61|44\n61|16\n61|37\n61|95\n61|76\n49|53\n49|16\n49|17\n49|98\n49|36\n49|86\n49|44\n49|31\n49|13\n49|73\n49|93\n49|63\n49|85\n49|11\n49|18\n49|48\n49|82\n49|57\n49|37\n49|39\n49|78\n49|75\n49|59\n49|45\n36|98\n36|31\n36|53\n36|63\n36|45\n36|75\n36|59\n36|44\n36|85\n36|11\n36|13\n36|39\n36|42\n36|86\n36|93\n36|73\n36|18\n36|78\n36|57\n36|48\n36|82\n36|17\n36|25\n36|16\n76|93\n76|39\n76|75\n76|73\n76|44\n76|16\n76|63\n76|86\n76|59\n76|46\n76|57\n76|37\n76|31\n76|11\n76|36\n76|48\n76|85\n76|17\n76|78\n76|49\n76|13\n76|53\n76|19\n58|99\n58|29\n58|76\n58|36\n58|56\n58|33\n58|79\n58|32\n58|63\n58|37\n58|86\n58|28\n58|11\n58|13\n58|24\n58|44\n58|57\n58|95\n58|46\n58|85\n58|55\n58|16\n44|18\n44|31\n44|21\n44|73\n44|42\n44|98\n44|53\n44|48\n44|57\n44|86\n44|11\n44|45\n44|93\n44|17\n44|82\n44|78\n44|63\n44|75\n44|84\n44|39\n44|85\n59|24\n59|82\n59|95\n59|45\n59|56\n59|61\n59|32\n59|29\n59|42\n59|98\n59|79\n59|21\n59|99\n59|93\n59|84\n59|58\n59|92\n59|28\n59|25\n59|54\n79|57\n79|46\n79|24\n79|86\n79|13\n79|11\n79|37\n79|56\n79|36\n79|17\n79|78\n79|48\n79|55\n79|16\n79|49\n79|19\n79|95\n79|32\n79|85\n99|76\n99|57\n99|46\n99|16\n99|29\n99|13\n99|95\n99|28\n99|32\n99|56\n99|86\n99|19\n99|11\n99|49\n99|18\n99|24\n99|37\n99|44\n86|59\n86|39\n86|17\n86|75\n86|98\n86|85\n86|93\n86|51\n86|21\n86|25\n86|53\n86|78\n86|84\n86|45\n86|82\n86|31\n86|42\n98|28\n98|25\n98|84\n98|51\n98|42\n98|71\n98|61\n98|21\n98|55\n98|45\n98|24\n98|92\n98|54\n98|33\n98|58\n98|56\n46|16\n46|37\n46|53\n46|59\n46|39\n46|36\n46|63\n46|78\n46|31\n46|86\n46|18\n46|11\n46|85\n46|73\n46|17\n56|48\n56|78\n56|13\n56|44\n56|49\n56|57\n56|18\n56|46\n56|19\n56|63\n56|76\n56|28\n56|16\n56|95\n85|73\n85|98\n85|17\n85|53\n85|31\n85|75\n85|93\n85|18\n85|48\n85|11\n85|42\n85|82\n85|35\n93|51\n93|35\n93|28\n93|29\n93|42\n93|45\n93|55\n93|71\n93|32\n93|98\n93|84\n93|25\n32|18\n32|36\n32|46\n32|16\n32|95\n32|75\n32|76\n32|49\n32|63\n32|86\n32|24\n35|46\n35|37\n35|29\n35|49\n35|58\n35|55\n35|99\n35|76\n35|95\n35|44\n45|19\n45|95\n45|61\n45|56\n45|28\n45|21\n45|35\n45|92\n45|55\n37|31\n37|17\n37|73\n37|98\n37|45\n37|13\n37|82\n37|78\n18|78\n18|98\n18|42\n18|82\n18|93\n18|92\n18|58\n13|25\n13|16\n13|57\n13|48\n13|73\n13|53\n53|59\n53|73\n53|29\n53|39\n53|33\n63|85\n63|53\n63|18\n63|78\n42|84\n42|99\n42|46\n29|56\n29|17\n19|93\n\n21,84,35,92,58,33,29,79,56,24,95,28,19,46,37\n46,17,63,48,59,76,75,78,16,73,49,53,57,18,36\n56,55,76,19,37,36,16,86,57,85,18,48,78\n25,73,98,54,21,59,39,45,75,71,99,92,82,31,35,33,42,51,61,29,53,58,93\n82,53,42,58,59,33,39,21,25,51,71,78,45\n73,31,98,78,84,75,53,17,93,21,39,92,48,82,58\n71,16,46,32,54,29,44\n44,63,17,31,82,86,93,39,37\n25,28,21,54,92,99,24,46,71,42,56,32,84,51,55\n49,37,36,13,44,16,86,57,63,85,11,18,48,17,78,53,75,39,31,59,93,98,45\n11,18,48,17,78,53,75,39,73,31,59,93,45,82,42,25,21,84,51,35,54,61,92\n17,39,85,75,16,86,48,59,98,49,53,13,57,11,45,63,37\n36,49,16,73,78,76,57,75,55,44,19\n39,73,31,59,98,45,82,42,21,84,51,35,61,71,33,29,79\n18,93,39,54,45,31,17,92,51,82,11\n11,29,55,57,76,48,18\n84,42,61,98,28,82,71,35,21,32,79,93,56,54,99,92,25,24,58,29,51\n98,82,61,31,53,73,92,21,33,93,58,99,25,54,75,29,71,35,59,42,84\n54,61,71,58,33,29,32,24,55\n75,82,84,71,33\n37,95,36,28,24,11,18,85,57,19,13,63,76,86,16,46,75\n32,56,61,31,51,59,82,33,79,58,21,29,71,54,45,98,93,84,92,35,24\n42,21,84,58,99,29,79,32,24,76,46\n45,75,31,85,18,11,98,25,59,93,82,13,73,63,57,16,39\n37,55,78,13,76,86,46,85,11,24,63,19,36,44,75,16,53\n61,86,29,16,24\n17,39,73,31,59,45,82,42,54,92,99\n17,78,53,75,73,31,59,93,98,45,82,42,25,84,51,35,54,61,92,71,99\n37,18,95,44,57\n63,18,31,59,39,25,11,48,57,44,53,98,42\n84,35,21,54,71,42,61,78,48,82,98,93,31,58,51\n76,78,13,37,32,85,16,24,49,28,11,57,46,63,95,19,18,44,17\n32,24,95,55,76,19,46,49,37,36,13,44,16,86,57,63,85,11,18,48,17,78,53\n13,85,19,17,36,16,63,39,78,86,57,48,37,18,75,46,95\n24,32,25,46,61,49,99,84,56,54,19,28,55\n57,63,85,11,18,48,17,78,53,39,73,31,59,93,98,45,82,42,25,21,84,51,35\n63,37,28,57,46,86,13,55,29,71,56,33,44,95,32,16,99,19,36\n92,61,79,25,99,33,24,28,21,82,76,35,19,71,42\n95,56,25,71,21,51,99,92,29,35,98,58,24,55,61\n98,53,46,13,63,11,37,93,18\n53,57,76,78,18,39,37,19,55,13,17,86,95\n39,73,31,59,45,82,42,21,51,54,61,92,99,29,56\n48,75,39,73,59,93,25,51,54,61,58\n51,53,21,39,84,57,31,35,25,59,93,85,78\n56,76,55,54,28,49,36,37,71,24,99,32,33,95,58,46,13,35,44\n95,28,55,76,46,49,13,16,57,63,85,11,18,48,17,78,53,75,39\n16,56,63,36,49,11,37,86,57,19,28,95,55,18,48\n73,31,59,93,98,45,25,21,84,35,54,61,92,71,58,99,33,29,79,56,32\n44,73,18,55,63,16,48,49,36,78,76,31,13\n75,73,31,59,93,45,82,42,25,21,84,51,35,54,92,71,58,99,33,29,79\n33,29,35,32,99,56,49,84,36,46,51,95,58,76,19,54,71,61,55\n11,31,85,78,73,59,42,84,35,53,21\n78,76,86,57,95,85,55,63,24,46,53,19,44,17,37,49,28,36,16,13,11\n29,33,45,76,61,82,24\n25,18,86,21,82,75,31,98,44,63,73,85,39,17,78,53,59,42,93,11,45,48,16\n79,75,59,21,71,93,29,33,82,54,92,35,99,51,31,73,98,39,45,25,42,84,58\n63,99,85,44,36,95,58,49,57\n99,29,79,56,32,24,28,55,76,46,49,37,36,44,86,57,63,85,11\n13,44,16,86,57,63,85,11,18,48,17,78,53,75,39,73,31,59,93,98,45,82,42\n32,95,58,33,79,21,35,93,42,71,28,61,84,29,24,25,98,99,56,54,92\n44,57,98,75,18,17,31,16,93,13,73,63,37,49,46\n85,17,78,53,75,73,59,93,98,45,82,25,21,35,54\n92,71,51,56,84,42,79,46,55,19,21\n54,29,36,61,56,79,33,44,71\n86,11,48,17,53,75,31,93,25,21,84\n95,28,76,49,44,86,57,85,18\n11,18,48,17,78,53,75,39,73,59,93,98,45,82,42,25,21,84,51,35,54,61,92\n19,29,55,28,58,33,44,37,79,16,95,49,85,13,36\n76,19,49,37,36,57,85,11,18,17,78,53,75,39,73\n76,37,57,85,17,39,59\n76,19,36,13,16,86,57,63,85,11,18,48,17,73,59\n16,86,57,63,85,11,48,17,78,53,39,73,59,98,45,82,42,21,84\n75,73,98,82,42,21,51,35,61,71,99,29,79\n85,86,13,11,44,28,99,49,57,56,76,37,55,95,63\n61,84,21,29,33,39,92,71,51,73,98,31,35,54,99,25,58,59,42,75,93,82,53\n19,46,49,37,36,13,16,86,57,63,85,11,78,53,75,39,73,31,59\n82,25,21,84,51,35,61,92,71,99,29,32,24,95,19\n61,92,71,58,99,33,29,79,56,32,24,95,28,55,19,46,49,13,44,16,86\n49,79,76,36,33,32,13,57,55,46,44,85,29,28,86,24,16\n98,45,82,42,21,84,51,35,54,61,92,71,58,99,33,29,32,24,95,28,55\n24,95,28,55,76,46,49,36,13,44,16,63,18,48,17,78,75\n79,24,76,19,37,36,57,48,17\n11,18,48,17,78,53,75,39,73,31,59,93,98,45,82,42,21,84,51,35,54,61,92\n36,13,44,16,86,57,63,85,11,48,17,78,53,75,39,73,31,59,93,98,45,82,42\n48,25,78,98,86\n85,18,53,73,31,82,84\n42,82,18,73,93,45,36\n37,36,13,44,16,86,57,63,85,18,17,78,53,75,39,73,31,59,93,98,82\n78,53,39,59,82,42,25,21,84,51,61,92,71,58,99\n45,82,42,25,21,84,51,35,54,92,71,58,99,33,29,79,56,32,24,95,28,55,76\n73,21,17,45,42,93,44,39,98,82,48,11,75,85,16,63,18,57,78,53,25\n84,92,71,99,32\n59,98,45,82,25,21,84,35,54,92,71,58,99,33,79,56,32,24,95\n32,19,54,44,36,95,28,99,61,16,46,37,49,79,71\n55,71,57,92,33,95,79\n61,42,85,25,39,53,73\n57,33,16,24,11,29,56,63,32,95,46,37,44,99,49\n84,51,92,55,32,82,25,28,21,24,54,33,29,56,95,58,42,35,79,19,71\n53,16,75,63,37,18,17,13,31,57,49\n85,36,17,49,37,28,73,39,11,78,18,75,19,55,48,63,76\n53,86,63,55,37,28,18,76,13,78,46,95,44,32,85\n57,63,18,48,17,75,39,73,31,59,98,45,82,42,25,21,84,51,35\n33,21,29,73,92,99,51,75,54,53,39\n63,48,78,98,86,73,31,57,11,82,42,21,53,84,93,85,16\n63,11,18,48,17,78,53,75,39,31,93,98,45,82,25,84,51,35,54\n61,71,99,33,29,95,86\n31,82,35,56,24,21,71,54,29\n31,98,21,84,92,29,32\n46,49,37,13,44,16,86,57,85,11,48,17,78,53,31,93,98\n45,82,84,55,33,42,35,29,95,51,56,28,76,79,54,21,32\n99,33,29,79,32,95,76,19,46,37,13,86,63,85,11\n21,79,46,35,71,58,55,42,32,33,92,29,24,61,54,84,95,19,56\n46,49,37,36,13,44,16,86,57,63,85,11,18,48,78,39,73,31,59,93,98\n35,54,61,92,71,58,99,33,29,79,56,32,24,95,28,76,19,46,49,37,36,13,44\n32,24,95,55,19,49,37,13,44,16,86,57,63,18,48\n36,39,86,17,57,73,18,85,75,46,49,11,31,59,98,78,48\n13,63,11,18,78,53,39,73,93,98,45,82,25\n71,56,95,13,61,24,46,35,58,44,19,29,76\n56,32,24,95,28,55,76,19,46,49,37,36,13,44,16,57,63,85,11,18,48,17,78\n32,19,18,17,86,46,79,37,28\n71,58,99,33,29,95,28,55,46,36,13,16,63\n29,95,76,32,25,21,71\n24,79,71,46,84,55,95,28,99\n46,37,36,86,44,29,33,79,28,32,18,85,49,55,57\n21,84,51,35,54,61,92,33,29,79,32,24,95,76,19,46,37\n16,61,19,56,33,54,92\n29,33,21,54,42,76,71,79,45,32,28,51,55,92,84\n33,37,28,29,46,63,13,49,86,79,56,24,55,44,18,57,32,16,76,85,19,95,36\n35,71,32,61,99,29,58\n28,49,92,13,95,61,51,46,19,36,33,32,58,76,55,24,35,56,79\n82,93,86,44,75,39,17,73,53,21,78,25,48\n93,61,79,21,84,71,56,25,35,42,54,92,29,45,95,33,24,59,32,51,58\n45,86,75,25,93,44,98,63,31,85,82\n51,35,54,71,99,33,95,28,76,19,49\n24,86,16,19,85,11,95,46,49,79,18,36,37,17,56,63,13,76,28,55,44\n49,37,86,76,33,95,79,44,13,99,46,28,85,58,16,32,24\n37,13,16,17,86,63,46,18,79,56,32\n36,99,19,44,76,29,24,57,92,58,55,46,86\n76,49,37,13,44,16,86,57,63,85,11,18,48,17,78,75,73,31,59\n53,75,39,31,93,51,35,61,71,58,99,33,29\n56,24,19,37,86,57,63,11,18\n17,44,86,55,36\n58,99,33,29,79,56,32,24,95,28,55,76,19,46,37,36,57,63,85\n53,11,95,17,28,32,85,36,37,18,24,13,19,57,49,63,46,78,86,55,76\n28,76,19,46,37,36,13,44,16,86,63,85,11,18,48,78,53,39,73\n95,19,32,79,99,35,71,61,49,29,37,58,36,28,56,24,55,51,54\n33,82,61,29,56,42,54,84,79,35,58\n28,13,55,24,57,63,44,29,48\n28,55,76,19,46,49,37,36,44,86,57,63,85,11,48,17,78,53,73\n46,49,37,36,13,16,57,63,85,11,18,48,78,53,73,31,59,93,98\n31,16,18,55,85,37,46,73,63\n45,84,16,57,78,11,48,73,98,63,17,93,85\n56,32,95,19,49,37,13,86,57,63,11,48,78\n59,93,98,45,82,42,25,84,61,92,99,29,95\n49,18,33,57,13,46,16,85,55,11,36,76,28,24,95,29,44,32,86\n18,48,17,53,39,73,31,98,45,82,25,51,71\n28,55,76,19,46,37,36,44,16,57,63,85,11,18,48,17,75,39,73\n31,82,42,25,21,84,54,99,33,56,24\n36,13,63,85,18,39,31,82,42\n95,49,85,19,46,55,57,36,18,79,17,56,44,86,32\n98,28,32,99,71,79,24,35,61,95,55,21,84\n75,92,98,17,51,59,45,21,93,54,78,18,31,71,53,25,39,42,35,61,82,73,84\n44,17,46,85,63,39,53,37,18,78,95,48,75,76,55,16,49\n24,19,49,36,44,16,86,57,11,48,78,53,75\n95,71,19,84,99,46,29,21,54,37,79,76,61,35,51\n36,11,78,48,73,53,93,59,17,75,16,49,63,19,37,57,39\n18,25,11,42,31,57,98,21,82,63,35,53,85,39,93,48,51,45,84,73,17,78,75\n45,21,35,98,99,95,58,92,42,61,56,71,24,82,59,93,32\n39,73,93,45,82,42,25,84,51,35,61,79,56\n85,86,19,36,55,78,39,53,31,46,18\n28,54,61,58,16,37,13,44,29,49,46\n11,18,17,78,39,73,31,59,98,45,25,84,35,54,92\n93,98,45,21,54,61,92,71,58,99,32,24,95\n98,21,55,82,29,56,42,33,51,84,32,54,61,79,28,24,95,58,35,25,71,45,92\n36,13,57,63,85,11,18,48,17,78,53,75,39,73,31,59,93,98,45,82,42\n54,28,21,24,42,19,82,25,33,32,95,71,35\n55,32,58,49,51,29,56,54,76,21,33,19,35,99,28,95,46\n51,35,54,61,92,71,58,99,33,79,56,24,95,28,55,19,46,49,37,36,13\n39,85,73,45,51,21,86\n61,79,92,54,76,36,46,44,49,13,99,95,58,71,55,29,32\n45,82,42,61,32,95,76\n48,53,75,39,31,93,45,42,25,21,84,51,54,61,58\n78,31,25,21,84,92,33\n61,56,98,33,29,59,32,54,93,51,35,25,73,79,99\n63,19,86,46,33,18,11\n58,42,56,84,61,46,35\n49,95,76,37,78,46,86,85,19,48,56,57,11,36,32\n24,21,51,29,45,79,71,28,32,56,35,95,98,33,42,84,58\n16,86,57,63,11,18,48,78,39,59,98,82,42,21,84\n35,54,61,71,33,29,32,24,28,19,46,49,37,36,13\n85,11,18,75,39,59,42,84,51,35,61\n78,33,98,75,42,21,58,45,73,93,92,31,35,99,61\n39,78,98,42,35,63,93,84,17\n71,76,92,55,79,84,24,51,58,49,35,99,36,28,37\n19,46,37,36,13,44,16,86,57,63,85,18,48,17,53,75,39,31,93\n28,54,21,35,25,76,55,95,49,79,92,32,33,99,71,29,51\n99,33,56,32,95,28,55,19,37,85,11\n95,46,16,85,37,28,11,13,32,63,24,17,36,19,78,56,86,44,18\n85,18,48,78,75,73,59,98,82,42,25,21,84,35,61\n29,79,56,32,24,95,28,55,76,19,49,37,36,13,16,86,57,63,85,18,48\n36,49,16,99,54,95,32\n93,58,51,56,31,92,35,61,25,82,42,45,32\n37,16,86,85,11,78,53,39,73,31,59,98,82";

            //Part 1
            int sum1 = CalculateMiddlePageNumberForCorrectUpdatesPart1(input);
            Console.WriteLine($"Sum of middle page numbers: {sum1}");

            //Part 2
            int sum2 = CalculateMiddlePageNumberForIncorrectUpdatesPart2(input);
            Console.WriteLine($"Sum of middle page numbers: {sum2}");
        }

        public static int CalculateMiddlePageNumberForCorrectUpdatesPart1(string input)
        {
            string[] sections = input.Split(new[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);

            if (sections.Length != 2)
            {
                throw new ArgumentException("Input should contain two sections: rules and updates");
            }

            var rulesSections = ParseRules(sections);
            var updatesSections = ParseUpdateSection(sections);

            var total = 0;
            foreach (var section in updatesSections)
            {
                if (IsUpdateInCorrectOrder(section, rulesSections))
                {
                    int middleIndex = section.Count / 2;
                    int middlePageNumber = section[middleIndex];
                
                    total += middlePageNumber;
                }
            }

            return total;
        }

        public static int CalculateMiddlePageNumberForIncorrectUpdatesPart2(string input)
        {
            string[] sections = input.Split(new[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);

            if (sections.Length != 2)
            {
                throw new ArgumentException("Input should contain two sections: rules and updates");
            }

            var rulesSections = ParseRules(sections);
            var updatesSections = ParseUpdateSection(sections);

            var total = 0;
            foreach (var section in updatesSections)
            {
                if (!IsUpdateInCorrectOrder(section, rulesSections))
                {
                    var reorderedSection = ReorderUpdate(section, rulesSections);
                    int middleIndex = reorderedSection.Count / 2;
                    int middlePageNumber = reorderedSection[middleIndex];
                    total += middlePageNumber;
                }
            }

            return total;
        }

        private static List<(int Before, int After)> ParseRules(string[] sections)
        {
            var rulesSections = new List<(int Before, int After)>();
            var ruleSection = sections[0].Split('\n', StringSplitOptions.RemoveEmptyEntries);

            foreach (var section in ruleSection)
            {
                if (section.Contains('|'))
                {
                    var parts = section.Split('|');

                    if (parts.Length == 2 &&
                        int.TryParse(parts[0], out int before) &&
                        int.TryParse(parts[1], out int after))
                    {
                        rulesSections.Add((before, after));
                    }
                }
            }

            return rulesSections;
        }

        private static List<List<int>> ParseUpdateSection(string[] sections)
        {
            var updatesSections = new List<List<int>>();
            var updateSection = sections[1].Split('\n', StringSplitOptions.RemoveEmptyEntries);

            foreach (var section in updateSection)
            {
                if (section.Contains(','))
                {
                    var parts = section.Split(',');
                    var temp = new List<int>();

                    foreach (var part in parts)
                    {
                        if (int.TryParse(part, out int number))
                        {
                            temp.Add(number);
                        }
                    }

                    if (temp.Count > 0)
                    {
                        updatesSections.Add(temp);
                    }
                }
            }

            return updatesSections;
        }

        private static bool IsUpdateInCorrectOrder(List<int> updateSection, List<(int Before, int After)> rulesSections)
        {
            for (int i = 0; i < updateSection.Count; i++)
            {
                for (int j = i + 1; j < updateSection.Count; j++)
                {
                    int before = updateSection[i];
                    int after = updateSection[j];

                    foreach (var rule in rulesSections)
                    {
                        if (rule.Before == after && rule.After == before)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private static List<int> ReorderUpdate(List<int> updateSection, List<(int Before, int After)> rulesSections)
        {
            var comparer = new PageComparer(new HashSet<(int before, int after)>(rulesSections));
            updateSection.Sort(comparer);
            return updateSection;
        }
    }
}

public class PageComparer : IComparer<int>
{
    private readonly HashSet<(int before, int after)> _rules;

    public PageComparer(HashSet<(int before, int after)> rules)
    {
        _rules = new HashSet<(int before, int after)>(rules);
    }

    public int Compare(int before, int after)
    {
        if (_rules.Contains((before, after)))
        {
            return -1;
        }
        else if (_rules.Contains((after, before)))
        {
            return 1;
        }

        return 0;
    }
}