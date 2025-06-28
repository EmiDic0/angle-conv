pkgname=angle-conv
pkgver=1.0.0
pkgrel=1
pkgdesc="A simple command line tool for converting angles between degrees and radians."
arch=('any')
url="https://github.com/EmiDic0/angle-conv"
makedepends=('dotnet-sdk')
source=("git+https://github.com/EmiDic0/angle-conv.git")
sha256sums=('SKIP')
build() {
    cd "$srcdir/$pkgname"
    dotnet publish
}

package() {
    cd "$srcdir/$pkgname"
    cp -r bin/Release/net9.0/publish/$pkgname "$pkgdir/usr/bin/"
}