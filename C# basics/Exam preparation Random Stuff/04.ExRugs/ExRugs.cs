use strict; 
 
my @arr; 
my $s = 3; 
 
my $n = 1; 
for my $a (0 .. $s) { 
     my $b = 0; 
     for (0 .. $a) { 
          $arr[$a - $b][$b++] = $n++; 
     } 
      
} 
$n = ($s + 1) ** 2; 
for my $a (0 .. $s - 1) { 
     my $b = 0;
     my $bi = $s;
     for (0 .. $a) {
          $arr[$s - $a + $b++][$bi--] = $n--;
     }
}

for my $i (0 .. $s) {
     for my $j (0 .. $s) {
          print $arr[$i][$j]."	";
     }
     print "
";
}