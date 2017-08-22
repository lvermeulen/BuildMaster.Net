param (
	[string]$BuildVersionNumber=$(throw "-BuildVersionNumber is required."),
	[string]$TagVersionNumber
)

& dotnet restore --no-cache

foreach ($src in ls $PSScriptRoot\..\src/*) {
    Push-Location $src

	Write-Output "build: Building & packaging project in $src"

    if ($TagVersionNumber -ne $null) {
        $version = $TagVersionNumber
    }
    else {
        $version = "1.0.0-$BuildVersionNumber"
    }

    & dotnet build -c Release --version-prefix="1.0.0" --version-suffix=$BuildVersionNumber
    & dotnet pack -c Release --include-symbols -o ..\..\artifacts --version $version --no-build
    if($LASTEXITCODE -ne 0) { exit 1 }    

    Pop-Location
}
