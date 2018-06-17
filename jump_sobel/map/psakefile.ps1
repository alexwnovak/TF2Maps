$mapName = "jump_sobel"
$mapFile = "$mapName.vmf"
$tf2Dir = "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2"

Task BuildGeometry {
    $vbspPath = Join-Path $tf2Dir "bin\vbsp.exe"
    $gameDir = Join-Path $tf2Dir "tf"

    $cmd = "`"$vbspPath`" -game `"$gameDir`" $mapFile"

    iex "& $cmd"
}

Task BuildVisibility -Depends BuildGeometry {
    $vvisPath = Join-Path $tf2Dir "bin\vvis.exe"
    $gameDir = Join-Path $tf2Dir "tf"

    $cmd = "`"$vvisPath`" -game `"$gameDir`" $mapFile"

    iex "& $cmd"
}

Task BuildLighting -Depends BuildVisibility {
    $vradPath = Join-Path $tf2Dir "bin\vrad.exe"
    $gameDir = Join-Path $tf2Dir "tf"

    $cmd = "`"$vradPath`" -game `"$gameDir`" $mapFile"

    iex "& $cmd" 
}

Task CopyBsp -Depends BuildLighting {
    $bspName = "$mapName.bsp"
    $mapDir = Join-Path $tf2Dir "tf\maps"

    copy $bspName $mapDir
}

Task Default -Depends CopyBsp
