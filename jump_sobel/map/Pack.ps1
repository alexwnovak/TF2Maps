$manifestName = "manifest.txt"
$bspName = [System.IO.Path]::GetFileName( $pwd )

Write-Host "================================================="
Write-Host "Packing $($bspName)..."
Write-Host "================================================="
Write-Host

Write-Host "Discovering content..."
$items = @()

gci Content -R | ? { !( $_.PSIsContainer ) } | % {
   $items += $_.FullName.Replace( [System.IO.Path]::Combine( $pwd, "Content" ), "" ).Substring( 1 )
   $items += $_.FullName
}

$items | Out-File -Encoding ASCII $manifestName
Write-Host "Packing..."

$source = [System.IO.Path]::Combine( $pwd, $bspName + ".bsp" )
$listFile = [System.IO.Path]::Combine( $pwd, $manifestName )
$output = [System.IO.Path]::Combine( $pwd, "Output", $bspName + ".bsp" )

#$source
#$listFile
#$output

& bspzip -addorupdatelist $source $listFile $output
#ri $manifestName

Write-Host "Done!"
Write-Host
