using GLUELib.Types;

namespace GLUELib.Items;

// ABS item
public class ABS : GLUEItem
{
  private readonly B _gtype;

  private ABS(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ABS(B gtype)
  {
    return new ABS(gtype);
  }

  public static implicit operator B(ABS gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ABS({_gtype})";
  }
}

// ACCESSMODE item
public class ACCESSMODE : GLUEItem
{
  private readonly U1 _gtype;

  private ACCESSMODE(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ACCESSMODE(U1 gtype)
  {
    return new ACCESSMODE(gtype);
  }

  public static implicit operator U1(ACCESSMODE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ACCESSMODE({_gtype})";
  }
}

// ACDS item
public class ACDS : GLUEItem
{
  private readonly U2 _gtype;

  private ACDS(U2 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ACDS(U2 gtype)
  {
    return new ACDS(gtype);
  }

  public static implicit operator U2(ACDS gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ACDS({_gtype})";
  }
}

// ACKA item
public class ACKA : GLUEItem
{
  private readonly TF _gtype;

  private ACKA(TF gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ACKA(TF gtype)
  {
    return new ACKA(gtype);
  }

  public static implicit operator TF(ACKA gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ACKA({_gtype})";
  }
}

// ACKC10 item
public class ACKC10 : GLUEItem
{
  private readonly B _gtype;

  private ACKC10(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ACKC10(B gtype)
  {
    return new ACKC10(gtype);
  }

  public static implicit operator B(ACKC10 gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ACKC10{_gtype}";
  }
}

// ACKC13 item
public class ACKC13 : GLUEItem
{
  private readonly B _gtype;

  private ACKC13(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ACKC13(B gtype)
  {
    return new ACKC13(gtype);
  }

  public static implicit operator B(ACKC13 gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ACKC13{_gtype}";
  }
}

// ACKC15 item
public class ACKC15 : GLUEItem
{
  private readonly B _gtype;

  private ACKC15(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ACKC15(B gtype)
  {
    return new ACKC15(gtype);
  }

  public static implicit operator B(ACKC15 gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ACKC15{_gtype}";
  }
}

// ACKC3 item
public class ACKC3 : GLUEItem
{
  private readonly B _gtype;

  private ACKC3(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ACKC3(B gtype)
  {
    return new ACKC3(gtype);
  }

  public static implicit operator B(ACKC3 gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ACKC3{_gtype}";
  }
}

// ACKC5 item
public class ACKC5 : GLUEItem
{
  private readonly B _gtype;

  private ACKC5(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ACKC5(B gtype)
  {
    return new ACKC5(gtype);
  }

  public static implicit operator B(ACKC5 gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ACKC5{_gtype}";
  }
}

// ACKC6 item
public class ACKC6 : GLUEItem
{
  private readonly B _gtype;

  private ACKC6(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ACKC6(B gtype)
  {
    return new ACKC6(gtype);
  }

  public static implicit operator B(ACKC6 gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ACKC6{_gtype}";
  }
}

// ACKC7 item
public class ACKC7 : GLUEItem
{
  private readonly B _gtype;

  private ACKC7(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ACKC7(B gtype)
  {
    return new ACKC7(gtype);
  }

  public static implicit operator B(ACKC7 gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ACKC7{_gtype}";
  }
}

// ACKC7A item
public class ACKC7A : GLUEItem
{
  private readonly U4 _gtype;

  private ACKC7A(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ACKC7A(U4 gtype)
  {
    return new ACKC7A(gtype);
  }

  public static implicit operator U4(ACKC7A gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ACKC7A{_gtype}";
  }
}

// AGENT item
public class AGENT : GLUEItem
{
  private readonly A _gtype;

  private AGENT(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator AGENT(A gtype)
  {
    return new AGENT(gtype);
  }

  public static implicit operator A(AGENT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"AGENT({_gtype})";
  }
}

// ALCD item
public class ALCD : GLUEItem
{
  private readonly B _gtype;

  private ALCD(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ALCD(B gtype)
  {
    return new ALCD(gtype);
  }

  public static implicit operator B(ALCD gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ALCD({_gtype})";
  }
}

// ALED item
public class ALED : GLUEItem
{
  private readonly B _gtype;

  private ALED(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ALED(B gtype)
  {
    return new ALED(gtype);
  }

  public static implicit operator B(ALED gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ALED({_gtype})";
  }
}

// ALID item
public class ALID : GLUEItem
{
  private readonly U4 _gtype;

  private ALID(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ALID(U4 gtype)
  {
    return new ALID(gtype);
  }

  public static implicit operator U4(ALID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ALID({_gtype})";
  }
}

// ALIDVECTOR item
public class ALIDVECTOR : GLUEItem
{
  private readonly U4 _gtype;

  private ALIDVECTOR(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ALIDVECTOR(U4 gtype)
  {
    return new ALIDVECTOR(gtype);
  }

  public static implicit operator U4(ALIDVECTOR gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ALIDVECTOR({_gtype})";
  }
}

// ALTX item
public class ALTX : GLUEItem
{
  private readonly A _gtype;

  private ALTX(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ALTX(A gtype)
  {
    return new ALTX(gtype);
  }

  public static implicit operator A(ALTX gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ALTX({_gtype})";
  }
}

// ASSGNID item
public class ASSGNID : GLUEItem
{
  private readonly U1 _gtype;

  private ASSGNID(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ASSGNID(U1 gtype)
  {
    return new ASSGNID(gtype);
  }

  public static implicit operator U1(ASSGNID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ASSGNID({_gtype})";
  }
}

// ATTRDATA item
public class ATTRDATA : GLUEItem
{
  private readonly A _gtype;

  private ATTRDATA(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ATTRDATA(A gtype)
  {
    return new ATTRDATA(gtype);
  }

  public static implicit operator A(ATTRDATA gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ATTRDATA({_gtype})";
  }
}

// ATTRID item
public class ATTRID : GLUEItem
{
  private readonly A _gtype;

  private ATTRID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ATTRID(A gtype)
  {
    return new ATTRID(gtype);
  }

  public static implicit operator A(ATTRID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ATTRID({_gtype})";
  }
}

// ATTRRELN item
public class ATTRRELN : GLUEItem
{
  private readonly U1 _gtype;

  private ATTRRELN(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ATTRRELN(U1 gtype)
  {
    return new ATTRRELN(gtype);
  }

  public static implicit operator U1(ATTRRELN gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ATTRRELN({_gtype})";
  }
}

// AUTOCLEAR_DISABLE item
public class AUTOCLEAR_DISABLE : GLUEItem
{
  private readonly U1 _gtype;

  private AUTOCLEAR_DISABLE(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator AUTOCLEAR_DISABLE(U1 gtype)
  {
    return new AUTOCLEAR_DISABLE(gtype);
  }

  public static implicit operator U1(AUTOCLEAR_DISABLE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"AUTOCLEAR_DISABLE({_gtype})";
  }
}

// AUTOCLOSE item
public class AUTOCLOSE : GLUEItem
{
  private readonly U2 _gtype;

  private AUTOCLOSE(U2 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator AUTOCLOSE(U2 gtype)
  {
    return new AUTOCLOSE(gtype);
  }

  public static implicit operator U2(AUTOCLOSE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"AUTOCLOSE({_gtype})";
  }
}

// AUTOPOST_DISABLE item
public class AUTOPOST_DISABLE : GLUEItem
{
  private readonly U1 _gtype;

  private AUTOPOST_DISABLE(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator AUTOPOST_DISABLE(U1 gtype)
  {
    return new AUTOPOST_DISABLE(gtype);
  }

  public static implicit operator U1(AUTOPOST_DISABLE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"AUTOPOST_DISABLE({_gtype})";
  }
}

// BCDS item
public class BCDS : GLUEItem
{
  private readonly U2 _gtype;

  private BCDS(U2 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator BCDS(U2 gtype)
  {
    return new BCDS(gtype);
  }

  public static implicit operator U2(BCDS gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"BCDS({_gtype})";
  }
}

// BCEQU item
public class BCEQU : GLUEItem
{
  private readonly U1 _gtype;

  private BCEQU(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator BCEQU(U1 gtype)
  {
    return new BCEQU(gtype);
  }

  public static implicit operator U1(BCEQU gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"BCEQU({_gtype})";
  }
}

// BINLT item
public class BINLT : GLUEItem
{
  private readonly U1 _gtype;

  private BINLT(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator BINLT(U1 gtype)
  {
    return new BINLT(gtype);
  }

  public static implicit operator U1(BINLT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"BINLT({_gtype})";
  }
}

// BLKDEF item
public class BLKDEF : GLUEItem
{
  private readonly I1 _gtype;

  private BLKDEF(I1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator BLKDEF(I1 gtype)
  {
    return new BLKDEF(gtype);
  }

  public static implicit operator I1(BLKDEF gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"BLKDEF({_gtype})";
  }
}

// BPD item
public class BPD : GLUEItem
{
  private readonly B _gtype;

  private BPD(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator BPD(B gtype)
  {
    return new BPD(gtype);
  }

  public static implicit operator B(BPD gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"BPD({_gtype})";
  }
}

// BYTMAX item
public class BYTMAX : GLUEItem
{
  private readonly U4 _gtype;

  private BYTMAX(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator BYTMAX(U4 gtype)
  {
    return new BYTMAX(gtype);
  }

  public static implicit operator U4(BYTMAX gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"BYTMAX({_gtype})";
  }
}

// CAACK item
public class CAACK : GLUEItem
{
  private readonly U1 _gtype;

  private CAACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CAACK(U1 gtype)
  {
    return new CAACK(gtype);
  }

  public static implicit operator U1(CAACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CAACK({_gtype})";
  }
}

// CARRIERACTION item
public class CARRIERACTION : GLUEItem
{
  private readonly A _gtype;

  private CARRIERACTION(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CARRIERACTION(A gtype)
  {
    return new CARRIERACTION(gtype);
  }

  public static implicit operator A(CARRIERACTION gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CARRIERACTION({_gtype})";
  }
}

// CARRIERID item
public class CARRIERID : GLUEItem
{
  private readonly A _gtype;

  private CARRIERID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CARRIERID(A gtype)
  {
    return new CARRIERID(gtype);
  }

  public static implicit operator A(CARRIERID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CARRIERID({_gtype})";
  }
}

// CARRIERSPEC item
public class CARRIERSPEC : GLUEItem
{
  private readonly A _gtype;

  private CARRIERSPEC(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CARRIERSPEC(A gtype)
  {
    return new CARRIERSPEC(gtype);
  }

  public static implicit operator A(CARRIERSPEC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CARRIERSPEC({_gtype})";
  }
}

// CATTRDATA item
public class CATTRDATA : GLUEItem
{
  private readonly A _gtype;

  private CATTRDATA(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CATTRDATA(A gtype)
  {
    return new CATTRDATA(gtype);
  }

  public static implicit operator A(CATTRDATA gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CATTRDATA({_gtype})";
  }
}

// CATTRID item
public class CATTRID : GLUEItem
{
  private readonly A _gtype;

  private CATTRID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CATTRID(A gtype)
  {
    return new CATTRID(gtype);
  }

  public static implicit operator A(CATTRID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CATTRID({_gtype})";
  }
}

// CCEACK item
public class CCEACK : GLUEItem
{
  private readonly U1 _gtype;

  private CCEACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CCEACK(U1 gtype)
  {
    return new CCEACK(gtype);
  }

  public static implicit operator U1(CCEACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CCEACK({_gtype})";
  }
}

// CCODE item
public class CCODE : GLUEItem
{
  private readonly A _gtype;

  private CCODE(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CCODE(A gtype)
  {
    return new CCODE(gtype);
  }

  public static implicit operator A(CCODE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CCODE({_gtype})";
  }
}

// CEED item
public class CEED : GLUEItem
{
  private readonly TF _gtype;

  private CEED(TF gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CEED(TF gtype)
  {
    return new CEED(gtype);
  }

  public static implicit operator TF(CEED gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CEED({_gtype})";
  }
}

// CEID item
public class CEID : GLUEItem
{
  private readonly U4 _gtype;

  private CEID(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CEID(U4 gtype)
  {
    return new CEID(gtype);
  }

  public static implicit operator U4(CEID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CEID({_gtype})";
  }
}

// CEIDSTART item
public class CEIDSTART : GLUEItem
{
  private readonly U4 _gtype;

  private CEIDSTART(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CEIDSTART(U4 gtype)
  {
    return new CEIDSTART(gtype);
  }

  public static implicit operator U4(CEIDSTART gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CEIDSTART({_gtype})";
  }
}

// CEIDSTOP item
public class CEIDSTOP : GLUEItem
{
  private readonly U4 _gtype;

  private CEIDSTOP(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CEIDSTOP(U4 gtype)
  {
    return new CEIDSTOP(gtype);
  }

  public static implicit operator U4(CEIDSTOP gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CEIDSTOP({_gtype})";
  }
}

// CENAME item
public class CENAME : GLUEItem
{
  private readonly A _gtype;

  private CENAME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CENAME(A gtype)
  {
    return new CENAME(gtype);
  }

  public static implicit operator A(CENAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CENAME({_gtype})";
  }
}

// CEPACK item
public class CEPACK : GLUEItem
{
  private readonly B _gtype;

  private CEPACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CEPACK(B gtype)
  {
    return new CEPACK(gtype);
  }

  public static implicit operator B(CEPACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CEPACK({_gtype})";
  }
}

// CEPVAL item
public class CEPVAL : GLUEItem
{
  private readonly A _gtype;

  private CEPVAL(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CEPVAL(A gtype)
  {
    return new CEPVAL(gtype);
  }

  public static implicit operator A(CEPVAL gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CEPVAL({_gtype})";
  }
}

// CHKINFO item
public class CHKINFO : GLUEItem
{
  private readonly A _gtype;

  private CHKINFO(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CHKINFO(A gtype)
  {
    return new CHKINFO(gtype);
  }

  public static implicit operator A(CHKINFO gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CHKINFO({_gtype})";
  }
}

// CKPNT item
public class CKPNT : GLUEItem
{
  private readonly U4 _gtype;

  private CKPNT(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CKPNT(U4 gtype)
  {
    return new CKPNT(gtype);
  }

  public static implicit operator U4(CKPNT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CKPNT({_gtype})";
  }
}

// CMDA item
public class CMDA : GLUEItem
{
  private readonly B _gtype;

  private CMDA(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CMDA(B gtype)
  {
    return new CMDA(gtype);
  }

  public static implicit operator B(CMDA gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CMDA({_gtype})";
  }
}

// CMDMAX item
public class CMDMAX : GLUEItem
{
  private readonly U1 _gtype;

  private CMDMAX(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CMDMAX(U1 gtype)
  {
    return new CMDMAX(gtype);
  }

  public static implicit operator U1(CMDMAX gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CMDMAX({_gtype})";
  }
}

// CNAME item
public class CNAME : GLUEItem
{
  private readonly A _gtype;

  private CNAME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CNAME(A gtype)
  {
    return new CNAME(gtype);
  }

  public static implicit operator A(CNAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CNAME({_gtype})";
  }
}

// COACK item
public class COACK : GLUEItem
{
  private readonly U1 _gtype;

  private COACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator COACK(U1 gtype)
  {
    return new COACK(gtype);
  }

  public static implicit operator U1(COACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"COACK({_gtype})";
  }
}

// COLCT item
public class COLCT : GLUEItem
{
  private readonly U4 _gtype;

  private COLCT(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator COLCT(U4 gtype)
  {
    return new COLCT(gtype);
  }

  public static implicit operator U4(COLCT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"COLCT({_gtype})";
  }
}

// COLHDR item
public class COLHDR : GLUEItem
{
  private readonly A _gtype;

  private COLHDR(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator COLHDR(A gtype)
  {
    return new COLHDR(gtype);
  }

  public static implicit operator A(COLHDR gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"COLHDR({_gtype})";
  }
}

// COMMACK item
public class COMMACK : GLUEItem
{
  private readonly B _gtype;

  private COMMACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator COMMACK(B gtype)
  {
    return new COMMACK(gtype);
  }

  public static implicit operator B(COMMACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"COMMACK({_gtype})";
  }
}

// COMPARISONOPERATOR item
public class COMPARISONOPERATOR : GLUEItem
{
  private readonly U1 _gtype;

  private COMPARISONOPERATOR(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator COMPARISONOPERATOR(U1 gtype)
  {
    return new COMPARISONOPERATOR(gtype);
  }

  public static implicit operator U1(COMPARISONOPERATOR gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"COMPARISONOPERATOR({_gtype})";
  }
}

// CONDITION item
public class CONDITION : GLUEItem
{
  private readonly A _gtype;

  private CONDITION(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CONDITION(A gtype)
  {
    return new CONDITION(gtype);
  }

  public static implicit operator A(CONDITION gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CONDITION({_gtype})";
  }
}

// COPYID item
public class COPYID : GLUEItem
{
  private readonly U1 _gtype;

  private COPYID(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator COPYID(U1 gtype)
  {
    return new COPYID(gtype);
  }

  public static implicit operator U1(COPYID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"COPYID({_gtype})";
  }
}

// CPACK item
public class CPACK : GLUEItem
{
  private readonly B _gtype;

  private CPACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CPACK(B gtype)
  {
    return new CPACK(gtype);
  }

  public static implicit operator B(CPACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CPACK({_gtype})";
  }
}

// CPNAME item
public class CPNAME : GLUEItem
{
  private readonly A _gtype;

  private CPNAME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CPNAME(A gtype)
  {
    return new CPNAME(gtype);
  }

  public static implicit operator A(CPNAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CPNAME({_gtype})";
  }
}

// CPVAL item
public class CPVAL : GLUEItem
{
  private readonly A _gtype;

  private CPVAL(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CPVAL(A gtype)
  {
    return new CPVAL(gtype);
  }

  public static implicit operator A(CPVAL gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CPVAL({_gtype})";
  }
}

// CSAACK item
public class CSAACK : GLUEItem
{
  private readonly U1 _gtype;

  private CSAACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CSAACK(U1 gtype)
  {
    return new CSAACK(gtype);
  }

  public static implicit operator U1(CSAACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CSAACK({_gtype})";
  }
}

// CTLJOBCMD item
public class CTLJOBCMD : GLUEItem
{
  private readonly U1 _gtype;

  private CTLJOBCMD(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CTLJOBCMD(U1 gtype)
  {
    return new CTLJOBCMD(gtype);
  }

  public static implicit operator U1(CTLJOBCMD gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CTLJOBCMD({_gtype})";
  }
}

// CTLJOBID item
public class CTLJOBID : GLUEItem
{
  private readonly A _gtype;

  private CTLJOBID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator CTLJOBID(A gtype)
  {
    return new CTLJOBID(gtype);
  }

  public static implicit operator A(CTLJOBID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"CTLJOBID({_gtype})";
  }
}

// DATA item
public class DATA : GLUEItem
{
  private readonly A _gtype;

  private DATA(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator DATA(A gtype)
  {
    return new DATA(gtype);
  }

  public static implicit operator A(DATA gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"DATA({_gtype})";
  }
}

// DATAACK item
public class DATAACK : GLUEItem
{
  private readonly B _gtype;

  private DATAACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator DATAACK(B gtype)
  {
    return new DATAACK(gtype);
  }

  public static implicit operator B(DATAACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"DATAACK({_gtype})";
  }
}

// DATAID item
public class DATAID : GLUEItem
{
  private readonly U4 _gtype;

  private DATAID(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator DATAID(U4 gtype)
  {
    return new DATAID(gtype);
  }

  public static implicit operator U4(DATAID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"DATAID({_gtype})";
  }
}

// DATALENGTH item
public class DATALENGTH : GLUEItem
{
  private readonly U4 _gtype;

  private DATALENGTH(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator DATALENGTH(U4 gtype)
  {
    return new DATALENGTH(gtype);
  }

  public static implicit operator U4(DATALENGTH gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"DATALENGTH({_gtype})";
  }
}

// DATASEG item
public class DATASEG : GLUEItem
{
  private readonly A _gtype;

  private DATASEG(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator DATASEG(A gtype)
  {
    return new DATASEG(gtype);
  }

  public static implicit operator A(DATASEG gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"DATASEG({_gtype})";
  }
}

// DATASRC item
public class DATASRC : GLUEItem
{
  private readonly A _gtype;

  private DATASRC(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator DATASRC(A gtype)
  {
    return new DATASRC(gtype);
  }

  public static implicit operator A(DATASRC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"DATASRC({_gtype})";
  }
}

// DATLC item
public class DATLC : GLUEItem
{
  private readonly U1 _gtype;

  private DATLC(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator DATLC(U1 gtype)
  {
    return new DATLC(gtype);
  }

  public static implicit operator U1(DATLC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"DATLC({_gtype})";
  }
}

// DELRSPSTAT item
public class DELRSPSTAT : GLUEItem
{
  private readonly U1 _gtype;

  private DELRSPSTAT(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator DELRSPSTAT(U1 gtype)
  {
    return new DELRSPSTAT(gtype);
  }

  public static implicit operator U1(DELRSPSTAT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"DELRSPSTAT({_gtype})";
  }
}

// DIRRSPSTAT item
public class DIRRSPSTAT : GLUEItem
{
  private readonly U1 _gtype;

  private DIRRSPSTAT(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator DIRRSPSTAT(U1 gtype)
  {
    return new DIRRSPSTAT(gtype);
  }

  public static implicit operator U1(DIRRSPSTAT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"DIRRSPSTAT({_gtype})";
  }
}

// DRACK item
public class DRACK : GLUEItem
{
  private readonly B _gtype;

  private DRACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator DRACK(B gtype)
  {
    return new DRACK(gtype);
  }

  public static implicit operator B(DRACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"DRACK({_gtype})";
  }
}

// DSID item
public class DSID : GLUEItem
{
  private readonly A _gtype;

  private DSID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator DSID(A gtype)
  {
    return new DSID(gtype);
  }

  public static implicit operator A(DSID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"DSID({_gtype})";
  }
}

// DSNAME item
public class DSNAME : GLUEItem
{
  private readonly A _gtype;

  private DSNAME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator DSNAME(A gtype)
  {
    return new DSNAME(gtype);
  }

  public static implicit operator A(DSNAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"DSNAME({_gtype})";
  }
}

// DSPER item
public class DSPER : GLUEItem
{
  private readonly A _gtype;

  private DSPER(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator DSPER(A gtype)
  {
    return new DSPER(gtype);
  }

  public static implicit operator A(DSPER gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"DSPER({_gtype})";
  }
}

// DUTMS item
public class DUTMS : GLUEItem
{
  private readonly A _gtype;

  private DUTMS(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator DUTMS(A gtype)
  {
    return new DUTMS(gtype);
  }

  public static implicit operator A(DUTMS gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"DUTMS({_gtype})";
  }
}

// DVNAME item
public class DVNAME : GLUEItem
{
  private readonly U4 _gtype;

  private DVNAME(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator DVNAME(U4 gtype)
  {
    return new DVNAME(gtype);
  }

  public static implicit operator U4(DVNAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"DVNAME({_gtype})";
  }
}

// DVVAL item
public class DVVAL : GLUEItem
{
  private readonly A _gtype;

  private DVVAL(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator DVVAL(A gtype)
  {
    return new DVVAL(gtype);
  }

  public static implicit operator A(DVVAL gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"DVVAL({_gtype})";
  }
}

// DVVALNAME item
public class DVVALNAME : GLUEItem
{
  private readonly A _gtype;

  private DVVALNAME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator DVVALNAME(A gtype)
  {
    return new DVVALNAME(gtype);
  }

  public static implicit operator A(DVVALNAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"DVVALNAME({_gtype})";
  }
}

// EAC item
public class EAC : GLUEItem
{
  private readonly B _gtype;

  private EAC(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator EAC(B gtype)
  {
    return new EAC(gtype);
  }

  public static implicit operator B(EAC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"EAC({_gtype})";
  }
}

// ECDEF item
public class ECDEF : GLUEItem
{
  private readonly A _gtype;

  private ECDEF(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ECDEF(A gtype)
  {
    return new ECDEF(gtype);
  }

  public static implicit operator A(ECDEF gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ECDEF({_gtype})";
  }
}

// ECID item
public class ECID : GLUEItem
{
  private readonly U4 _gtype;

  private ECID(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ECID(U4 gtype)
  {
    return new ECID(gtype);
  }

  public static implicit operator U4(ECID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ECID({_gtype})";
  }
}

// ECMAX item
public class ECMAX : GLUEItem
{
  private readonly A _gtype;

  private ECMAX(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ECMAX(A gtype)
  {
    return new ECMAX(gtype);
  }

  public static implicit operator A(ECMAX gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ECMAX({_gtype})";
  }
}

// ECMIN item
public class ECMIN : GLUEItem
{
  private readonly A _gtype;

  private ECMIN(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ECMIN(A gtype)
  {
    return new ECMIN(gtype);
  }

  public static implicit operator A(ECMIN gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ECMIN({_gtype})";
  }
}

// ECNAME item
public class ECNAME : GLUEItem
{
  private readonly A _gtype;

  private ECNAME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ECNAME(A gtype)
  {
    return new ECNAME(gtype);
  }

  public static implicit operator A(ECNAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ECNAME({_gtype})";
  }
}

// ECV item
public class ECV : GLUEItem
{
  private readonly A _gtype;

  private ECV(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ECV(A gtype)
  {
    return new ECV(gtype);
  }

  public static implicit operator A(ECV gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ECV({_gtype})";
  }
}

// EDID item
public class EDID : GLUEItem
{
  private readonly A _gtype;

  private EDID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator EDID(A gtype)
  {
    return new EDID(gtype);
  }

  public static implicit operator A(EDID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"EDID({_gtype})";
  }
}

// EMID item
public class EMID : GLUEItem
{
  private readonly A _gtype;

  private EMID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator EMID(A gtype)
  {
    return new EMID(gtype);
  }

  public static implicit operator A(EMID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"EMID({_gtype})";
  }
}

// EPD item
public class EPD : GLUEItem
{
  private readonly B _gtype;

  private EPD(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator EPD(B gtype)
  {
    return new EPD(gtype);
  }

  public static implicit operator B(EPD gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"EPD({_gtype})";
  }
}

// EQID item
public class EQID : GLUEItem
{
  private readonly A _gtype;

  private EQID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator EQID(A gtype)
  {
    return new EQID(gtype);
  }

  public static implicit operator A(EQID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"EQID({_gtype})";
  }
}

// EQNAME item
public class EQNAME : GLUEItem
{
  private readonly A _gtype;

  private EQNAME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator EQNAME(A gtype)
  {
    return new EQNAME(gtype);
  }

  public static implicit operator A(EQNAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"EQNAME({_gtype})";
  }
}

// EQUSERID item
public class EQUSERID : GLUEItem
{
  private readonly A _gtype;

  private EQUSERID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator EQUSERID(A gtype)
  {
    return new EQUSERID(gtype);
  }

  public static implicit operator A(EQUSERID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"EQUSERID({_gtype})";
  }
}

// ERACK item
public class ERACK : GLUEItem
{
  private readonly B _gtype;

  private ERACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ERACK(B gtype)
  {
    return new ERACK(gtype);
  }

  public static implicit operator B(ERACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ERACK({_gtype})";
  }
}

// ERRCODE item
public class ERRCODE : GLUEItem
{
  private readonly U4 _gtype;

  private ERRCODE(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ERRCODE(U4 gtype)
  {
    return new ERRCODE(gtype);
  }

  public static implicit operator U4(ERRCODE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ERRCODE({_gtype})";
  }
}

// ERRTEXT item
public class ERRTEXT : GLUEItem
{
  private readonly A _gtype;

  private ERRTEXT(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ERRTEXT(A gtype)
  {
    return new ERRTEXT(gtype);
  }

  public static implicit operator A(ERRTEXT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ERRTEXT({_gtype})";
  }
}

// ERRW7 item
public class ERRW7 : GLUEItem
{
  private readonly A _gtype;

  private ERRW7(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ERRW7(A gtype)
  {
    return new ERRW7(gtype);
  }

  public static implicit operator A(ERRW7 gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ERRW7({_gtype})";
  }
}

// EVNTSRC item
public class EVNTSRC : GLUEItem
{
  private readonly A _gtype;

  private EVNTSRC(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator EVNTSRC(A gtype)
  {
    return new EVNTSRC(gtype);
  }

  public static implicit operator A(EVNTSRC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"EVNTSRC({_gtype})";
  }
}

// EVNTSRC2 item
public class EVNTSRC2 : GLUEItem
{
  private readonly A _gtype;

  private EVNTSRC2(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator EVNTSRC2(A gtype)
  {
    return new EVNTSRC2(gtype);
  }

  public static implicit operator A(EVNTSRC2 gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"EVNTSRC2({_gtype})";
  }
}

// EXID item
public class EXID : GLUEItem
{
  private readonly A _gtype;

  private EXID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator EXID(A gtype)
  {
    return new EXID(gtype);
  }

  public static implicit operator A(EXID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"EXID({_gtype})";
  }
}

// EXMESSAGE item
public class EXMESSAGE : GLUEItem
{
  private readonly A _gtype;

  private EXMESSAGE(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator EXMESSAGE(A gtype)
  {
    return new EXMESSAGE(gtype);
  }

  public static implicit operator A(EXMESSAGE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"EXMESSAGE({_gtype})";
  }
}

// EXRECVRA item
public class EXRECVRA : GLUEItem
{
  private readonly A _gtype;

  private EXRECVRA(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator EXRECVRA(A gtype)
  {
    return new EXRECVRA(gtype);
  }

  public static implicit operator A(EXRECVRA gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"EXRECVRA({_gtype})";
  }
}

// EXTYPE item
public class EXTYPE : GLUEItem
{
  private readonly A _gtype;

  private EXTYPE(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator EXTYPE(A gtype)
  {
    return new EXTYPE(gtype);
  }

  public static implicit operator A(EXTYPE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"EXTYPE({_gtype})";
  }
}

// FCNID item
public class FCNID : GLUEItem
{
  private readonly U1 _gtype;

  private FCNID(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator FCNID(U1 gtype)
  {
    return new FCNID(gtype);
  }

  public static implicit operator U1(FCNID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"FCNID({_gtype})";
  }
}

// FFROT item
public class FFROT : GLUEItem
{
  private readonly U2 _gtype;

  private FFROT(U2 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator FFROT(U2 gtype)
  {
    return new FFROT(gtype);
  }

  public static implicit operator U2(FFROT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"FFROT({_gtype})";
  }
}

// FILDAT item
public class FILDAT : GLUEItem
{
  private readonly B _gtype;

  private FILDAT(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator FILDAT(B gtype)
  {
    return new FILDAT(gtype);
  }

  public static implicit operator B(FILDAT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"FILDAT({_gtype})";
  }
}

// FNLOC item
public class FNLOC : GLUEItem
{
  private readonly U2 _gtype;

  private FNLOC(U2 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator FNLOC(U2 gtype)
  {
    return new FNLOC(gtype);
  }

  public static implicit operator U2(FNLOC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"FNLOC({_gtype})";
  }
}

// FRMLEN item
public class FRMLEN : GLUEItem
{
  private readonly U4 _gtype;

  private FRMLEN(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator FRMLEN(U4 gtype)
  {
    return new FRMLEN(gtype);
  }

  public static implicit operator U4(FRMLEN gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"FRMLEN({_gtype})";
  }
}

// GETRSPSTAT item
public class GETRSPSTAT : GLUEItem
{
  private readonly U1 _gtype;

  private GETRSPSTAT(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator GETRSPSTAT(U1 gtype)
  {
    return new GETRSPSTAT(gtype);
  }

  public static implicit operator U1(GETRSPSTAT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"GETRSPSTAT({_gtype})";
  }
}

// GOILACK item
public class GOILACK : GLUEItem
{
  private readonly U1 _gtype;

  private GOILACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator GOILACK(U1 gtype)
  {
    return new GOILACK(gtype);
  }

  public static implicit operator U1(GOILACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"GOILACK({_gtype})";
  }
}

// GRANT item
public class GRANT : GLUEItem
{
  private readonly B _gtype;

  private GRANT(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator GRANT(B gtype)
  {
    return new GRANT(gtype);
  }

  public static implicit operator B(GRANT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"GRANT({_gtype})";
  }
}

// GRANT6 item
public class GRANT6 : GLUEItem
{
  private readonly B _gtype;

  private GRANT6(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator GRANT6(B gtype)
  {
    return new GRANT6(gtype);
  }

  public static implicit operator B(GRANT6 gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"GRANT6({_gtype})";
  }
}

// GRNT1 item
public class GRNT1 : GLUEItem
{
  private readonly B _gtype;

  private GRNT1(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator GRNT1(B gtype)
  {
    return new GRNT1(gtype);
  }

  public static implicit operator B(GRNT1 gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"GRNT1({_gtype})";
  }
}

// GRXLACK item
public class GRXLACK : GLUEItem
{
  private readonly U1 _gtype;

  private GRXLACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator GRXLACK(U1 gtype)
  {
    return new GRXLACK(gtype);
  }

  public static implicit operator U1(GRXLACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"GRXLACK({_gtype})";
  }
}

// HANDLE item
public class HANDLE : GLUEItem
{
  private readonly U4 _gtype;

  private HANDLE(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator HANDLE(U4 gtype)
  {
    return new HANDLE(gtype);
  }

  public static implicit operator U4(HANDLE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"HANDLE({_gtype})";
  }
}

// HCACK item
public class HCACK : GLUEItem
{
  private readonly B _gtype;

  private HCACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator HCACK(B gtype)
  {
    return new HCACK(gtype);
  }

  public static implicit operator B(HCACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"HCACK({_gtype})";
  }
}

// HOACK item
public class HOACK : GLUEItem
{
  private readonly TF _gtype;

  private HOACK(TF gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator HOACK(TF gtype)
  {
    return new HOACK(gtype);
  }

  public static implicit operator TF(HOACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"HOACK({_gtype})";
  }
}

// HOCANCELACK item
public class HOCANCELACK : GLUEItem
{
  private readonly U1 _gtype;

  private HOCANCELACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator HOCANCELACK(U1 gtype)
  {
    return new HOCANCELACK(gtype);
  }

  public static implicit operator U1(HOCANCELACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"HOCANCELACK({_gtype})";
  }
}

// HOCMDNAME item
public class HOCMDNAME : GLUEItem
{
  private readonly A _gtype;

  private HOCMDNAME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator HOCMDNAME(A gtype)
  {
    return new HOCMDNAME(gtype);
  }

  public static implicit operator A(HOCMDNAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"HOCMDNAME({_gtype})";
  }
}

// HOHALTACK item
public class HOHALTACK : GLUEItem
{
  private readonly U1 _gtype;

  private HOHALTACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator HOHALTACK(U1 gtype)
  {
    return new HOHALTACK(gtype);
  }

  public static implicit operator U1(HOHALTACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"HOHALTACK({_gtype})";
  }
}

// IACDS item
public class IACDS : GLUEItem
{
  private readonly U2 _gtype;

  private IACDS(U2 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator IACDS(U2 gtype)
  {
    return new IACDS(gtype);
  }

  public static implicit operator U2(IACDS gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"IACDS({_gtype})";
  }
}

// IBCDS item
public class IBCDS : GLUEItem
{
  private readonly U2 _gtype;

  private IBCDS(U2 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator IBCDS(U2 gtype)
  {
    return new IBCDS(gtype);
  }

  public static implicit operator U2(IBCDS gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"IBCDS({_gtype})";
  }
}

// IDTYP item
public class IDTYP : GLUEItem
{
  private readonly B _gtype;

  private IDTYP(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator IDTYP(B gtype)
  {
    return new IDTYP(gtype);
  }

  public static implicit operator B(IDTYP gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"IDTYP({_gtype})";
  }
}

// INPTN item
public class INPTN : GLUEItem
{
  private readonly B _gtype;

  private INPTN(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator INPTN(B gtype)
  {
    return new INPTN(gtype);
  }

  public static implicit operator B(INPTN gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"INPTN({_gtype})";
  }
}

// ITEMACK item
public class ITEMACK : GLUEItem
{
  private readonly B _gtype;

  private ITEMACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ITEMACK(B gtype)
  {
    return new ITEMACK(gtype);
  }

  public static implicit operator B(ITEMACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ITEMACK({_gtype})";
  }
}

// ITEMERROR item
public class ITEMERROR : GLUEItem
{
  private readonly A _gtype;

  private ITEMERROR(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ITEMERROR(A gtype)
  {
    return new ITEMERROR(gtype);
  }

  public static implicit operator A(ITEMERROR gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ITEMERROR({_gtype})";
  }
}

// ITEMID item
public class ITEMID : GLUEItem
{
  private readonly A _gtype;

  private ITEMID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ITEMID(A gtype)
  {
    return new ITEMID(gtype);
  }

  public static implicit operator A(ITEMID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ITEMID({_gtype})";
  }
}

// ITEMINDEX item
public class ITEMINDEX : GLUEItem
{
  private readonly U4 _gtype;

  private ITEMINDEX(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ITEMINDEX(U4 gtype)
  {
    return new ITEMINDEX(gtype);
  }

  public static implicit operator U4(ITEMINDEX gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ITEMINDEX({_gtype})";
  }
}

// ITEMLENGTH item
public class ITEMLENGTH : GLUEItem
{
  private readonly U4 _gtype;

  private ITEMLENGTH(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ITEMLENGTH(U4 gtype)
  {
    return new ITEMLENGTH(gtype);
  }

  public static implicit operator U4(ITEMLENGTH gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ITEMLENGTH({_gtype})";
  }
}

// ITEMPART item
public class ITEMPART : GLUEItem
{
  private readonly A _gtype;

  private ITEMPART(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ITEMPART(A gtype)
  {
    return new ITEMPART(gtype);
  }

  public static implicit operator A(ITEMPART gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ITEMPART({_gtype})";
  }
}

// ITEMPARTCOUNT item
public class ITEMPARTCOUNT : GLUEItem
{
  private readonly U4 _gtype;

  private ITEMPARTCOUNT(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ITEMPARTCOUNT(U4 gtype)
  {
    return new ITEMPARTCOUNT(gtype);
  }

  public static implicit operator U4(ITEMPARTCOUNT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ITEMPARTCOUNT({_gtype})";
  }
}

// ITEMPARTLENGTH item
public class ITEMPARTLENGTH : GLUEItem
{
  private readonly U4 _gtype;

  private ITEMPARTLENGTH(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ITEMPARTLENGTH(U4 gtype)
  {
    return new ITEMPARTLENGTH(gtype);
  }

  public static implicit operator U4(ITEMPARTLENGTH gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ITEMPARTLENGTH({_gtype})";
  }
}

// ITEMTYPE item
public class ITEMTYPE : GLUEItem
{
  private readonly A _gtype;

  private ITEMTYPE(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ITEMTYPE(A gtype)
  {
    return new ITEMTYPE(gtype);
  }

  public static implicit operator A(ITEMTYPE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ITEMTYPE({_gtype})";
  }
}

// ITEMTYPESUPPORT item
public class ITEMTYPESUPPORT : GLUEItem
{
  private readonly U4 _gtype;

  private ITEMTYPESUPPORT(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ITEMTYPESUPPORT(U4 gtype)
  {
    return new ITEMTYPESUPPORT(gtype);
  }

  public static implicit operator U4(ITEMTYPESUPPORT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ITEMTYPESUPPORT({_gtype})";
  }
}

// ITEMVERSION item
public class ITEMVERSION : GLUEItem
{
  private readonly A _gtype;

  private ITEMVERSION(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ITEMVERSION(A gtype)
  {
    return new ITEMVERSION(gtype);
  }

  public static implicit operator A(ITEMVERSION gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ITEMVERSION({_gtype})";
  }
}

// JOBACTION item
public class JOBACTION : GLUEItem
{
  private readonly A _gtype;

  private JOBACTION(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator JOBACTION(A gtype)
  {
    return new JOBACTION(gtype);
  }

  public static implicit operator A(JOBACTION gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"JOBACTION({_gtype})";
  }
}

// LENGTH item
public class LENGTH : GLUEItem
{
  private readonly U4 _gtype;

  private LENGTH(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator LENGTH(U4 gtype)
  {
    return new LENGTH(gtype);
  }

  public static implicit operator U4(LENGTH gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"LENGTH({_gtype})";
  }
}

// LIMITACK item
public class LIMITACK : GLUEItem
{
  private readonly B _gtype;

  private LIMITACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator LIMITACK(B gtype)
  {
    return new LIMITACK(gtype);
  }

  public static implicit operator B(LIMITACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"LIMITACK({_gtype})";
  }
}

// LIMITID item
public class LIMITID : GLUEItem
{
  private readonly B _gtype;

  private LIMITID(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator LIMITID(B gtype)
  {
    return new LIMITID(gtype);
  }

  public static implicit operator B(LIMITID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"LIMITID({_gtype})";
  }
}

// LIMITMAX item
public class LIMITMAX : GLUEItem
{
  private readonly F4 _gtype;

  private LIMITMAX(F4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator LIMITMAX(F4 gtype)
  {
    return new LIMITMAX(gtype);
  }

  public static implicit operator F4(LIMITMAX gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"LIMITMAX({_gtype})";
  }
}

// LIMITMIN item
public class LIMITMIN : GLUEItem
{
  private readonly F4 _gtype;

  private LIMITMIN(F4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator LIMITMIN(F4 gtype)
  {
    return new LIMITMIN(gtype);
  }

  public static implicit operator F4(LIMITMIN gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"LIMITMIN({_gtype})";
  }
}

// LINKID item
public class LINKID : GLUEItem
{
  private readonly U4 _gtype;

  private LINKID(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator LINKID(U4 gtype)
  {
    return new LINKID(gtype);
  }

  public static implicit operator U4(LINKID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"LINKID({_gtype})";
  }
}

// LOC item
public class LOC : GLUEItem
{
  private readonly B _gtype;

  private LOC(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator LOC(B gtype)
  {
    return new LOC(gtype);
  }

  public static implicit operator B(LOC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"LOC({_gtype})";
  }
}

// LOCID item
public class LOCID : GLUEItem
{
  private readonly A _gtype;

  private LOCID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator LOCID(A gtype)
  {
    return new LOCID(gtype);
  }

  public static implicit operator A(LOCID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"LOCID({_gtype})";
  }
}

// LOWERDB item
public class LOWERDB : GLUEItem
{
  private readonly F4 _gtype;

  private LOWERDB(F4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator LOWERDB(F4 gtype)
  {
    return new LOWERDB(gtype);
  }

  public static implicit operator F4(LOWERDB gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"LOWERDB({_gtype})";
  }
}

// LRACK item
public class LRACK : GLUEItem
{
  private readonly B _gtype;

  private LRACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator LRACK(B gtype)
  {
    return new LRACK(gtype);
  }

  public static implicit operator B(LRACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"LRACK({_gtype})";
  }
}

// LVACK item
public class LVACK : GLUEItem
{
  private readonly B _gtype;

  private LVACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator LVACK(B gtype)
  {
    return new LVACK(gtype);
  }

  public static implicit operator B(LVACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"LVACK({_gtype})";
  }
}

// MAPER item
public class MAPER : GLUEItem
{
  private readonly B _gtype;

  private MAPER(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator MAPER(B gtype)
  {
    return new MAPER(gtype);
  }

  public static implicit operator B(MAPER gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"MAPER({_gtype})";
  }
}

// MAPFT item
public class MAPFT : GLUEItem
{
  private readonly B _gtype;

  private MAPFT(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator MAPFT(B gtype)
  {
    return new MAPFT(gtype);
  }

  public static implicit operator B(MAPFT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"MAPFT({_gtype})";
  }
}

// MAXNUMBER item
public class MAXNUMBER : GLUEItem
{
  private readonly U2 _gtype;

  private MAXNUMBER(U2 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator MAXNUMBER(U2 gtype)
  {
    return new MAXNUMBER(gtype);
  }

  public static implicit operator U2(MAXNUMBER gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"MAXNUMBER({_gtype})";
  }
}

// MAXTIME item
public class MAXTIME : GLUEItem
{
  private readonly U2 _gtype;

  private MAXTIME(U2 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator MAXTIME(U2 gtype)
  {
    return new MAXTIME(gtype);
  }

  public static implicit operator U2(MAXTIME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"MAXTIME({_gtype})";
  }
}

// MCINDEX item
public class MCINDEX : GLUEItem
{
  private readonly U4 _gtype;

  private MCINDEX(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator MCINDEX(U4 gtype)
  {
    return new MCINDEX(gtype);
  }

  public static implicit operator U4(MCINDEX gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"MCINDEX({_gtype})";
  }
}

// MDACK item
public class MDACK : GLUEItem
{
  private readonly B _gtype;

  private MDACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator MDACK(B gtype)
  {
    return new MDACK(gtype);
  }

  public static implicit operator B(MDACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"MDACK({_gtype})";
  }
}

// MDLN item
public class MDLN : GLUEItem
{
  private readonly A _gtype;

  private MDLN(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator MDLN(A gtype)
  {
    return new MDLN(gtype);
  }

  public static implicit operator A(MDLN gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"MDLN({_gtype})";
  }
}

// MEXP item
public class MEXP : GLUEItem
{
  private readonly A _gtype;

  private MEXP(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator MEXP(A gtype)
  {
    return new MEXP(gtype);
  }

  public static implicit operator A(MEXP gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"MEXP({_gtype})";
  }
}

// MF item
public class MF : GLUEItem
{
  private readonly B _gtype;

  private MF(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator MF(B gtype)
  {
    return new MF(gtype);
  }

  public static implicit operator B(MF gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"MF({_gtype})";
  }
}

// MHEAD item
public class MHEAD : GLUEItem
{
  private readonly B _gtype;

  private MHEAD(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator MHEAD(B gtype)
  {
    return new MHEAD(gtype);
  }

  public static implicit operator B(MHEAD gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"MHEAD({_gtype})";
  }
}

// MID item
public class MID : GLUEItem
{
  private readonly A _gtype;

  private MID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator MID(A gtype)
  {
    return new MID(gtype);
  }

  public static implicit operator A(MID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"MID({_gtype})";
  }
}

// MIDAC item
public class MIDAC : GLUEItem
{
  private readonly B _gtype;

  private MIDAC(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator MIDAC(B gtype)
  {
    return new MIDAC(gtype);
  }

  public static implicit operator B(MIDAC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"MIDAC({_gtype})";
  }
}

// MIDRA item
public class MIDRA : GLUEItem
{
  private readonly B _gtype;

  private MIDRA(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator MIDRA(B gtype)
  {
    return new MIDRA(gtype);
  }

  public static implicit operator B(MIDRA gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"MIDRA({_gtype})";
  }
}

// MLCL item
public class MLCL : GLUEItem
{
  private readonly U4 _gtype;

  private MLCL(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator MLCL(U4 gtype)
  {
    return new MLCL(gtype);
  }

  public static implicit operator U4(MLCL gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"MLCL({_gtype})";
  }
}

// MMODE item
public class MMODE : GLUEItem
{
  private readonly B _gtype;

  private MMODE(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator MMODE(B gtype)
  {
    return new MMODE(gtype);
  }

  public static implicit operator B(MMODE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"MMODE({_gtype})";
  }
}

// NACDS item
public class NACDS : GLUEItem
{
  private readonly U2 _gtype;

  private NACDS(U2 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator NACDS(U2 gtype)
  {
    return new NACDS(gtype);
  }

  public static implicit operator U2(NACDS gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"NACDS({_gtype})";
  }
}

// NBCDS item
public class NBCDS : GLUEItem
{
  private readonly U2 _gtype;

  private NBCDS(U2 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator NBCDS(U2 gtype)
  {
    return new NBCDS(gtype);
  }

  public static implicit operator U2(NBCDS gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"NBCDS({_gtype})";
  }
}

// NULBC item
public class NULBC : GLUEItem
{
  private readonly A _gtype;

  private NULBC(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator NULBC(A gtype)
  {
    return new NULBC(gtype);
  }

  public static implicit operator A(NULBC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"NULBC({_gtype})";
  }
}

// OBJACK item
public class OBJACK : GLUEItem
{
  private readonly U1 _gtype;

  private OBJACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator OBJACK(U1 gtype)
  {
    return new OBJACK(gtype);
  }

  public static implicit operator U1(OBJACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"OBJACK({_gtype})";
  }
}

// OBJCMD item
public class OBJCMD : GLUEItem
{
  private readonly U1 _gtype;

  private OBJCMD(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator OBJCMD(U1 gtype)
  {
    return new OBJCMD(gtype);
  }

  public static implicit operator U1(OBJCMD gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"OBJCMD({_gtype})";
  }
}

// OBJID item
public class OBJID : GLUEItem
{
  private readonly A _gtype;

  private OBJID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator OBJID(A gtype)
  {
    return new OBJID(gtype);
  }

  public static implicit operator A(OBJID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"OBJID({_gtype})";
  }
}

// OBJSPEC item
public class OBJSPEC : GLUEItem
{
  private readonly A _gtype;

  private OBJSPEC(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator OBJSPEC(A gtype)
  {
    return new OBJSPEC(gtype);
  }

  public static implicit operator A(OBJSPEC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"OBJSPEC({_gtype})";
  }
}

// OBJTOKEN item
public class OBJTOKEN : GLUEItem
{
  private readonly U4 _gtype;

  private OBJTOKEN(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator OBJTOKEN(U4 gtype)
  {
    return new OBJTOKEN(gtype);
  }

  public static implicit operator U4(OBJTOKEN gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"OBJTOKEN({_gtype})";
  }
}

// OBJTYPE item
public class OBJTYPE : GLUEItem
{
  private readonly A _gtype;

  private OBJTYPE(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator OBJTYPE(A gtype)
  {
    return new OBJTYPE(gtype);
  }

  public static implicit operator A(OBJTYPE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"OBJTYPE({_gtype})";
  }
}

// OCEACK item
public class OCEACK : GLUEItem
{
  private readonly U1 _gtype;

  private OCEACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator OCEACK(U1 gtype)
  {
    return new OCEACK(gtype);
  }

  public static implicit operator U1(OCEACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"OCEACK({_gtype})";
  }
}

// OFLACK item
public class OFLACK : GLUEItem
{
  private readonly B _gtype;

  private OFLACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator OFLACK(B gtype)
  {
    return new OFLACK(gtype);
  }

  public static implicit operator B(OFLACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"OFLACK({_gtype})";
  }
}

// ONLACK item
public class ONLACK : GLUEItem
{
  private readonly B _gtype;

  private ONLACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ONLACK(B gtype)
  {
    return new ONLACK(gtype);
  }

  public static implicit operator B(ONLACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ONLACK({_gtype})";
  }
}

// OPEID item
public class OPEID : GLUEItem
{
  private readonly A _gtype;

  private OPEID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator OPEID(A gtype)
  {
    return new OPEID(gtype);
  }

  public static implicit operator A(OPEID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"OPEID({_gtype})";
  }
}

// OPETYPE item
public class OPETYPE : GLUEItem
{
  private readonly U1 _gtype;

  private OPETYPE(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator OPETYPE(U1 gtype)
  {
    return new OPETYPE(gtype);
  }

  public static implicit operator U1(OPETYPE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"OPETYPE({_gtype})";
  }
}

// OPID item
public class OPID : GLUEItem
{
  private readonly U4 _gtype;

  private OPID(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator OPID(U4 gtype)
  {
    return new OPID(gtype);
  }

  public static implicit operator U4(OPID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"OPID({_gtype})";
  }
}

// ORLOC item
public class ORLOC : GLUEItem
{
  private readonly B _gtype;

  private ORLOC(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ORLOC(B gtype)
  {
    return new ORLOC(gtype);
  }

  public static implicit operator B(ORLOC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ORLOC({_gtype})";
  }
}

// OUTPTN item
public class OUTPTN : GLUEItem
{
  private readonly B _gtype;

  private OUTPTN(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator OUTPTN(B gtype)
  {
    return new OUTPTN(gtype);
  }

  public static implicit operator B(OUTPTN gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"OUTPTN({_gtype})";
  }
}

// PARAMNAME item
public class PARAMNAME : GLUEItem
{
  private readonly A _gtype;

  private PARAMNAME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PARAMNAME(A gtype)
  {
    return new PARAMNAME(gtype);
  }

  public static implicit operator A(PARAMNAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PARAMNAME({_gtype})";
  }
}

// PARAMVAL item
public class PARAMVAL : GLUEItem
{
  private readonly U1 _gtype;

  private PARAMVAL(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PARAMVAL(U1 gtype)
  {
    return new PARAMVAL(gtype);
  }

  public static implicit operator U1(PARAMVAL gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PARAMVAL({_gtype})";
  }
}

// PDEATTRIBUTE item
public class PDEATTRIBUTE : GLUEItem
{
  private readonly U1 _gtype;

  private PDEATTRIBUTE(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PDEATTRIBUTE(U1 gtype)
  {
    return new PDEATTRIBUTE(gtype);
  }

  public static implicit operator U1(PDEATTRIBUTE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PDEATTRIBUTE({_gtype})";
  }
}

// PDEATTRIBUTENAME item
public class PDEATTRIBUTENAME : GLUEItem
{
  private readonly U1 _gtype;

  private PDEATTRIBUTENAME(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PDEATTRIBUTENAME(U1 gtype)
  {
    return new PDEATTRIBUTENAME(gtype);
  }

  public static implicit operator U1(PDEATTRIBUTENAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PDEATTRIBUTENAME({_gtype})";
  }
}

// PDEATTRIBUTEVALUE item
public class PDEATTRIBUTEVALUE : GLUEItem
{
  private readonly A _gtype;

  private PDEATTRIBUTEVALUE(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PDEATTRIBUTEVALUE(A gtype)
  {
    return new PDEATTRIBUTEVALUE(gtype);
  }

  public static implicit operator A(PDEATTRIBUTEVALUE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PDEATTRIBUTEVALUE({_gtype})";
  }
}

// PDEREF item
public class PDEREF : GLUEItem
{
  private readonly A _gtype;

  private PDEREF(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PDEREF(A gtype)
  {
    return new PDEREF(gtype);
  }

  public static implicit operator A(PDEREF gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PDEREF({_gtype})";
  }
}

// PECEACK item
public class PECEACK : GLUEItem
{
  private readonly U1 _gtype;

  private PECEACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PECEACK(U1 gtype)
  {
    return new PECEACK(gtype);
  }

  public static implicit operator U1(PECEACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PECEACK({_gtype})";
  }
}

// PECRSLT item
public class PECRSLT : GLUEItem
{
  private readonly U1 _gtype;

  private PECRSLT(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PECRSLT(U1 gtype)
  {
    return new PECRSLT(gtype);
  }

  public static implicit operator U1(PECRSLT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PECRSLT({_gtype})";
  }
}

// PFCD item
public class PFCD : GLUEItem
{
  private readonly B _gtype;

  private PFCD(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PFCD(B gtype)
  {
    return new PFCD(gtype);
  }

  public static implicit operator B(PFCD gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PFCD({_gtype})";
  }
}

// PGRPACTION item
public class PGRPACTION : GLUEItem
{
  private readonly A _gtype;

  private PGRPACTION(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PGRPACTION(A gtype)
  {
    return new PGRPACTION(gtype);
  }

  public static implicit operator A(PGRPACTION gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PGRPACTION({_gtype})";
  }
}

// PODID item
public class PODID : GLUEItem
{
  private readonly A _gtype;

  private PODID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PODID(A gtype)
  {
    return new PODID(gtype);
  }

  public static implicit operator A(PODID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PODID({_gtype})";
  }
}

// PORTACTION item
public class PORTACTION : GLUEItem
{
  private readonly A _gtype;

  private PORTACTION(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PORTACTION(A gtype)
  {
    return new PORTACTION(gtype);
  }

  public static implicit operator A(PORTACTION gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PORTACTION({_gtype})";
  }
}

// PORTGRPNAME item
public class PORTGRPNAME : GLUEItem
{
  private readonly A _gtype;

  private PORTGRPNAME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PORTGRPNAME(A gtype)
  {
    return new PORTGRPNAME(gtype);
  }

  public static implicit operator A(PORTGRPNAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PORTGRPNAME({_gtype})";
  }
}

// PPARM item
public class PPARM : GLUEItem
{
  private readonly A _gtype;

  private PPARM(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PPARM(A gtype)
  {
    return new PPARM(gtype);
  }

  public static implicit operator A(PPARM gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PPARM({_gtype})";
  }
}

// PPBODY item
public class PPBODY : GLUEItem
{
  private readonly B _gtype;

  private PPBODY(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PPBODY(B gtype)
  {
    return new PPBODY(gtype);
  }

  public static implicit operator B(PPBODY gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PPBODY({_gtype})";
  }
}

// PPGNT item
public class PPGNT : GLUEItem
{
  private readonly B _gtype;

  private PPGNT(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PPGNT(B gtype)
  {
    return new PPGNT(gtype);
  }

  public static implicit operator B(PPGNT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PPGNT({_gtype})";
  }
}

// PPID item
public class PPID : GLUEItem
{
  private readonly A _gtype;

  private PPID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PPID(A gtype)
  {
    return new PPID(gtype);
  }

  public static implicit operator A(PPID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PPID({_gtype})";
  }
}

// PRAXI item
public class PRAXI : GLUEItem
{
  private readonly B _gtype;

  private PRAXI(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PRAXI(B gtype)
  {
    return new PRAXI(gtype);
  }

  public static implicit operator B(PRAXI gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PRAXI({_gtype})";
  }
}

// PRCMDNAME item
public class PRCMDNAME : GLUEItem
{
  private readonly A _gtype;

  private PRCMDNAME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PRCMDNAME(A gtype)
  {
    return new PRCMDNAME(gtype);
  }

  public static implicit operator A(PRCMDNAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PRCMDNAME({_gtype})";
  }
}

// PRCPREEXECHK item
public class PRCPREEXECHK : GLUEItem
{
  private readonly U1 _gtype;

  private PRCPREEXECHK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PRCPREEXECHK(U1 gtype)
  {
    return new PRCPREEXECHK(gtype);
  }

  public static implicit operator U1(PRCPREEXECHK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PRCPREEXECHK({_gtype})";
  }
}

// PRDCT item
public class PRDCT : GLUEItem
{
  private readonly U4 _gtype;

  private PRDCT(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PRDCT(U4 gtype)
  {
    return new PRDCT(gtype);
  }

  public static implicit operator U4(PRDCT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PRDCT({_gtype})";
  }
}

// PREACK item
public class PREACK : GLUEItem
{
  private readonly U1 _gtype;

  private PREACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PREACK(U1 gtype)
  {
    return new PREACK(gtype);
  }

  public static implicit operator U1(PREACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PREACK({_gtype})";
  }
}

// PREVENTID item
public class PREVENTID : GLUEItem
{
  private readonly U1 _gtype;

  private PREVENTID(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PREVENTID(U1 gtype)
  {
    return new PREVENTID(gtype);
  }

  public static implicit operator U1(PREVENTID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PREVENTID({_gtype})";
  }
}

// PRJOBID item
public class PRJOBID : GLUEItem
{
  private readonly A _gtype;

  private PRJOBID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PRJOBID(A gtype)
  {
    return new PRJOBID(gtype);
  }

  public static implicit operator A(PRJOBID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PRJOBID({_gtype})";
  }
}

// PRJOBMILESTONE item
public class PRJOBMILESTONE : GLUEItem
{
  private readonly U1 _gtype;

  private PRJOBMILESTONE(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PRJOBMILESTONE(U1 gtype)
  {
    return new PRJOBMILESTONE(gtype);
  }

  public static implicit operator U1(PRJOBMILESTONE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PRJOBMILESTONE({_gtype})";
  }
}

// PRJOBSPACE item
public class PRJOBSPACE : GLUEItem
{
  private readonly U2 _gtype;

  private PRJOBSPACE(U2 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PRJOBSPACE(U2 gtype)
  {
    return new PRJOBSPACE(gtype);
  }

  public static implicit operator U2(PRJOBSPACE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PRJOBSPACE({_gtype})";
  }
}

// PRMTRLORDER item
public class PRMTRLORDER : GLUEItem
{
  private readonly U1 _gtype;

  private PRMTRLORDER(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PRMTRLORDER(U1 gtype)
  {
    return new PRMTRLORDER(gtype);
  }

  public static implicit operator U1(PRMTRLORDER gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PRMTRLORDER({_gtype})";
  }
}

// PRPAUSEEVENTID item
public class PRPAUSEEVENTID : GLUEItem
{
  private readonly U4 _gtype;

  private PRPAUSEEVENTID(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PRPAUSEEVENTID(U4 gtype)
  {
    return new PRPAUSEEVENTID(gtype);
  }

  public static implicit operator U4(PRPAUSEEVENTID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PRPAUSEEVENTID({_gtype})";
  }
}

// PRPROCESSSTART item
public class PRPROCESSSTART : GLUEItem
{
  private readonly TF _gtype;

  private PRPROCESSSTART(TF gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PRPROCESSSTART(TF gtype)
  {
    return new PRPROCESSSTART(gtype);
  }

  public static implicit operator TF(PRPROCESSSTART gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PRPROCESSSTART({_gtype})";
  }
}

// PRRECIPEMETHOD item
public class PRRECIPEMETHOD : GLUEItem
{
  private readonly U1 _gtype;

  private PRRECIPEMETHOD(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PRRECIPEMETHOD(U1 gtype)
  {
    return new PRRECIPEMETHOD(gtype);
  }

  public static implicit operator U1(PRRECIPEMETHOD gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PRRECIPEMETHOD({_gtype})";
  }
}

// PRSTATE item
public class PRSTATE : GLUEItem
{
  private readonly U1 _gtype;

  private PRSTATE(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PRSTATE(U1 gtype)
  {
    return new PRSTATE(gtype);
  }

  public static implicit operator U1(PRSTATE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PRSTATE({_gtype})";
  }
}

// PSRACK item
public class PSRACK : GLUEItem
{
  private readonly U1 _gtype;

  private PSRACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PSRACK(U1 gtype)
  {
    return new PSRACK(gtype);
  }

  public static implicit operator U1(PSRACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PSRACK({_gtype})";
  }
}

// PSREACK item
public class PSREACK : GLUEItem
{
  private readonly U1 _gtype;

  private PSREACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PSREACK(U1 gtype)
  {
    return new PSREACK(gtype);
  }

  public static implicit operator U1(PSREACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PSREACK({_gtype})";
  }
}

// PTN item
public class PTN : GLUEItem
{
  private readonly U1 _gtype;

  private PTN(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator PTN(U1 gtype)
  {
    return new PTN(gtype);
  }

  public static implicit operator U1(PTN gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"PTN({_gtype})";
  }
}

// QPRKEACK item
public class QPRKEACK : GLUEItem
{
  private readonly U1 _gtype;

  private QPRKEACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator QPRKEACK(U1 gtype)
  {
    return new QPRKEACK(gtype);
  }

  public static implicit operator U1(QPRKEACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"QPRKEACK({_gtype})";
  }
}

// QREACK item
public class QREACK : GLUEItem
{
  private readonly U1 _gtype;

  private QREACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator QREACK(U1 gtype)
  {
    return new QREACK(gtype);
  }

  public static implicit operator U1(QREACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"QREACK({_gtype})";
  }
}

// QRXLEACK item
public class QRXLEACK : GLUEItem
{
  private readonly U1 _gtype;

  private QRXLEACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator QRXLEACK(U1 gtype)
  {
    return new QRXLEACK(gtype);
  }

  public static implicit operator U1(QRXLEACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"QRXLEACK({_gtype})";
  }
}

// QUA item
public class QUA : GLUEItem
{
  private readonly B _gtype;

  private QUA(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator QUA(B gtype)
  {
    return new QUA(gtype);
  }

  public static implicit operator B(QUA gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"QUA({_gtype})";
  }
}

// RAC item
public class RAC : GLUEItem
{
  private readonly U1 _gtype;

  private RAC(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RAC(U1 gtype)
  {
    return new RAC(gtype);
  }

  public static implicit operator U1(RAC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RAC({_gtype})";
  }
}

// RCMD item
public class RCMD : GLUEItem
{
  private readonly A _gtype;

  private RCMD(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCMD(A gtype)
  {
    return new RCMD(gtype);
  }

  public static implicit operator A(RCMD gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCMD({_gtype})";
  }
}

// RCPATTRDATA item
public class RCPATTRDATA : GLUEItem
{
  private readonly A _gtype;

  private RCPATTRDATA(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPATTRDATA(A gtype)
  {
    return new RCPATTRDATA(gtype);
  }

  public static implicit operator A(RCPATTRDATA gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPATTRDATA({_gtype})";
  }
}

// RCPATTRID item
public class RCPATTRID : GLUEItem
{
  private readonly A _gtype;

  private RCPATTRID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPATTRID(A gtype)
  {
    return new RCPATTRID(gtype);
  }

  public static implicit operator A(RCPATTRID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPATTRID({_gtype})";
  }
}

// RCPBODY item
public class RCPBODY : GLUEItem
{
  private readonly B _gtype;

  private RCPBODY(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPBODY(B gtype)
  {
    return new RCPBODY(gtype);
  }

  public static implicit operator B(RCPBODY gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPBODY({_gtype})";
  }
}

// RCPBODYA item
public class RCPBODYA : GLUEItem
{
  private readonly A _gtype;

  private RCPBODYA(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPBODYA(A gtype)
  {
    return new RCPBODYA(gtype);
  }

  public static implicit operator A(RCPBODYA gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPBODYA({_gtype})";
  }
}

// RCPCLASS item
public class RCPCLASS : GLUEItem
{
  private readonly A _gtype;

  private RCPCLASS(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPCLASS(A gtype)
  {
    return new RCPCLASS(gtype);
  }

  public static implicit operator A(RCPCLASS gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPCLASS({_gtype})";
  }
}

// RCPCMD item
public class RCPCMD : GLUEItem
{
  private readonly U1 _gtype;

  private RCPCMD(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPCMD(U1 gtype)
  {
    return new RCPCMD(gtype);
  }

  public static implicit operator U1(RCPCMD gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPCMD({_gtype})";
  }
}

// RCPDEL item
public class RCPDEL : GLUEItem
{
  private readonly U1 _gtype;

  private RCPDEL(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPDEL(U1 gtype)
  {
    return new RCPDEL(gtype);
  }

  public static implicit operator U1(RCPDEL gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPDEL({_gtype})";
  }
}

// RCPDESCLTH item
public class RCPDESCLTH : GLUEItem
{
  private readonly U4 _gtype;

  private RCPDESCLTH(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPDESCLTH(U4 gtype)
  {
    return new RCPDESCLTH(gtype);
  }

  public static implicit operator U4(RCPDESCLTH gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPDESCLTH({_gtype})";
  }
}

// RCPDESCNM item
public class RCPDESCNM : GLUEItem
{
  private readonly A _gtype;

  private RCPDESCNM(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPDESCNM(A gtype)
  {
    return new RCPDESCNM(gtype);
  }

  public static implicit operator A(RCPDESCNM gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPDESCNM({_gtype})";
  }
}

// RCPDESCTIME item
public class RCPDESCTIME : GLUEItem
{
  private readonly A _gtype;

  private RCPDESCTIME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPDESCTIME(A gtype)
  {
    return new RCPDESCTIME(gtype);
  }

  public static implicit operator A(RCPDESCTIME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPDESCTIME({_gtype})";
  }
}

// RCPID item
public class RCPID : GLUEItem
{
  private readonly A _gtype;

  private RCPID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPID(A gtype)
  {
    return new RCPID(gtype);
  }

  public static implicit operator A(RCPID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPID({_gtype})";
  }
}

// RCPNAME item
public class RCPNAME : GLUEItem
{
  private readonly A _gtype;

  private RCPNAME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPNAME(A gtype)
  {
    return new RCPNAME(gtype);
  }

  public static implicit operator A(RCPNAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPNAME({_gtype})";
  }
}

// RCPNEWID item
public class RCPNEWID : GLUEItem
{
  private readonly A _gtype;

  private RCPNEWID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPNEWID(A gtype)
  {
    return new RCPNEWID(gtype);
  }

  public static implicit operator A(RCPNEWID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPNEWID({_gtype})";
  }
}

// RCPOWCODE item
public class RCPOWCODE : GLUEItem
{
  private readonly TF _gtype;

  private RCPOWCODE(TF gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPOWCODE(TF gtype)
  {
    return new RCPOWCODE(gtype);
  }

  public static implicit operator TF(RCPOWCODE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPOWCODE({_gtype})";
  }
}

// RCPPARNM item
public class RCPPARNM : GLUEItem
{
  private readonly A _gtype;

  private RCPPARNM(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPPARNM(A gtype)
  {
    return new RCPPARNM(gtype);
  }

  public static implicit operator A(RCPPARNM gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPPARNM({_gtype})";
  }
}

// RCPPARRULE item
public class RCPPARRULE : GLUEItem
{
  private readonly A _gtype;

  private RCPPARRULE(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPPARRULE(A gtype)
  {
    return new RCPPARRULE(gtype);
  }

  public static implicit operator A(RCPPARRULE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPPARRULE({_gtype})";
  }
}

// RCPPARVAL item
public class RCPPARVAL : GLUEItem
{
  private readonly A _gtype;

  private RCPPARVAL(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPPARVAL(A gtype)
  {
    return new RCPPARVAL(gtype);
  }

  public static implicit operator A(RCPPARVAL gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPPARVAL({_gtype})";
  }
}

// RCPRENAME item
public class RCPRENAME : GLUEItem
{
  private readonly TF _gtype;

  private RCPRENAME(TF gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPRENAME(TF gtype)
  {
    return new RCPRENAME(gtype);
  }

  public static implicit operator TF(RCPRENAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPRENAME({_gtype})";
  }
}

// RCPSECCODE item
public class RCPSECCODE : GLUEItem
{
  private readonly B _gtype;

  private RCPSECCODE(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPSECCODE(B gtype)
  {
    return new RCPSECCODE(gtype);
  }

  public static implicit operator B(RCPSECCODE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPSECCODE({_gtype})";
  }
}

// RCPSECNM item
public class RCPSECNM : GLUEItem
{
  private readonly A _gtype;

  private RCPSECNM(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPSECNM(A gtype)
  {
    return new RCPSECNM(gtype);
  }

  public static implicit operator A(RCPSECNM gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPSECNM({_gtype})";
  }
}

// RCPSPEC item
public class RCPSPEC : GLUEItem
{
  private readonly A _gtype;

  private RCPSPEC(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPSPEC(A gtype)
  {
    return new RCPSPEC(gtype);
  }

  public static implicit operator A(RCPSPEC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPSPEC({_gtype})";
  }
}

// RCPSTAT item
public class RCPSTAT : GLUEItem
{
  private readonly U1 _gtype;

  private RCPSTAT(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPSTAT(U1 gtype)
  {
    return new RCPSTAT(gtype);
  }

  public static implicit operator U1(RCPSTAT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPSTAT({_gtype})";
  }
}

// RCPUPDT item
public class RCPUPDT : GLUEItem
{
  private readonly TF _gtype;

  private RCPUPDT(TF gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPUPDT(TF gtype)
  {
    return new RCPUPDT(gtype);
  }

  public static implicit operator TF(RCPUPDT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPUPDT({_gtype})";
  }
}

// RCPVERS item
public class RCPVERS : GLUEItem
{
  private readonly A _gtype;

  private RCPVERS(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RCPVERS(A gtype)
  {
    return new RCPVERS(gtype);
  }

  public static implicit operator A(RCPVERS gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RCPVERS({_gtype})";
  }
}

// READLN item
public class READLN : GLUEItem
{
  private readonly U4 _gtype;

  private READLN(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator READLN(U4 gtype)
  {
    return new READLN(gtype);
  }

  public static implicit operator U4(READLN gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"READLN({_gtype})";
  }
}

// REAPER item
public class REAPER : GLUEItem
{
  private readonly A _gtype;

  private REAPER(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator REAPER(A gtype)
  {
    return new REAPER(gtype);
  }

  public static implicit operator A(REAPER gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"REAPER({_gtype})";
  }
}

// RECLEN item
public class RECLEN : GLUEItem
{
  private readonly U4 _gtype;

  private RECLEN(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RECLEN(U4 gtype)
  {
    return new RECLEN(gtype);
  }

  public static implicit operator U4(RECLEN gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RECLEN({_gtype})";
  }
}

// REFP item
public class REFP : GLUEItem
{
  private readonly I4 _gtype;

  private REFP(I4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator REFP(I4 gtype)
  {
    return new REFP(gtype);
  }

  public static implicit operator I4(REFP gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"REFP({_gtype})";
  }
}

// REPGSZ item
public class REPGSZ : GLUEItem
{
  private readonly U4 _gtype;

  private REPGSZ(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator REPGSZ(U4 gtype)
  {
    return new REPGSZ(gtype);
  }

  public static implicit operator U4(REPGSZ gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"REPGSZ({_gtype})";
  }
}

// RESOLUTION item
public class RESOLUTION : GLUEItem
{
  private readonly A _gtype;

  private RESOLUTION(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RESOLUTION(A gtype)
  {
    return new RESOLUTION(gtype);
  }

  public static implicit operator A(RESOLUTION gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RESOLUTION({_gtype})";
  }
}

// RESPDESTAT item
public class RESPDESTAT : GLUEItem
{
  private readonly U1 _gtype;

  private RESPDESTAT(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RESPDESTAT(U1 gtype)
  {
    return new RESPDESTAT(gtype);
  }

  public static implicit operator U1(RESPDESTAT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RESPDESTAT({_gtype})";
  }
}

// RESPEC item
public class RESPEC : GLUEItem
{
  private readonly A _gtype;

  private RESPEC(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RESPEC(A gtype)
  {
    return new RESPEC(gtype);
  }

  public static implicit operator A(RESPEC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RESPEC({_gtype})";
  }
}

// RETAINRECIPE_DISABLE item
public class RETAINRECIPE_DISABLE : GLUEItem
{
  private readonly U1 _gtype;

  private RETAINRECIPE_DISABLE(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RETAINRECIPE_DISABLE(U1 gtype)
  {
    return new RETAINRECIPE_DISABLE(gtype);
  }

  public static implicit operator U1(RETAINRECIPE_DISABLE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RETAINRECIPE_DISABLE({_gtype})";
  }
}

// RETICLEID item
public class RETICLEID : GLUEItem
{
  private readonly A _gtype;

  private RETICLEID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RETICLEID(A gtype)
  {
    return new RETICLEID(gtype);
  }

  public static implicit operator A(RETICLEID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RETICLEID({_gtype})";
  }
}

// RETICLEID2 item
public class RETICLEID2 : GLUEItem
{
  private readonly A _gtype;

  private RETICLEID2(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RETICLEID2(A gtype)
  {
    return new RETICLEID2(gtype);
  }

  public static implicit operator A(RETICLEID2 gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RETICLEID2({_gtype})";
  }
}

// RETPLACEINSTR item
public class RETPLACEINSTR : GLUEItem
{
  private readonly U1 _gtype;

  private RETPLACEINSTR(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RETPLACEINSTR(U1 gtype)
  {
    return new RETPLACEINSTR(gtype);
  }

  public static implicit operator U1(RETPLACEINSTR gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RETPLACEINSTR({_gtype})";
  }
}

// RETREMOVEINSTR item
public class RETREMOVEINSTR : GLUEItem
{
  private readonly U1 _gtype;

  private RETREMOVEINSTR(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RETREMOVEINSTR(U1 gtype)
  {
    return new RETREMOVEINSTR(gtype);
  }

  public static implicit operator U1(RETREMOVEINSTR gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RETREMOVEINSTR({_gtype})";
  }
}

// REVID item
public class REVID : GLUEItem
{
  private readonly A _gtype;

  private REVID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator REVID(A gtype)
  {
    return new REVID(gtype);
  }

  public static implicit operator A(REVID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"REVID({_gtype})";
  }
}

// RIC item
public class RIC : GLUEItem
{
  private readonly U1 _gtype;

  private RIC(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RIC(U1 gtype)
  {
    return new RIC(gtype);
  }

  public static implicit operator U1(RIC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RIC({_gtype})";
  }
}

// RMACK item
public class RMACK : GLUEItem
{
  private readonly U1 _gtype;

  private RMACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RMACK(U1 gtype)
  {
    return new RMACK(gtype);
  }

  public static implicit operator U1(RMACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RMACK({_gtype})";
  }
}

// RMCHGSTAT item
public class RMCHGSTAT : GLUEItem
{
  private readonly U4 _gtype;

  private RMCHGSTAT(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RMCHGSTAT(U4 gtype)
  {
    return new RMCHGSTAT(gtype);
  }

  public static implicit operator U4(RMCHGSTAT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RMCHGSTAT({_gtype})";
  }
}

// RMCHGTYPE item
public class RMCHGTYPE : GLUEItem
{
  private readonly U4 _gtype;

  private RMCHGTYPE(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RMCHGTYPE(U4 gtype)
  {
    return new RMCHGTYPE(gtype);
  }

  public static implicit operator U4(RMCHGTYPE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RMCHGTYPE({_gtype})";
  }
}

// RMDATASIZE item
public class RMDATASIZE : GLUEItem
{
  private readonly U4 _gtype;

  private RMDATASIZE(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RMDATASIZE(U4 gtype)
  {
    return new RMDATASIZE(gtype);
  }

  public static implicit operator U4(RMDATASIZE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RMDATASIZE({_gtype})";
  }
}

// RMGRNT item
public class RMGRNT : GLUEItem
{
  private readonly B _gtype;

  private RMGRNT(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RMGRNT(B gtype)
  {
    return new RMGRNT(gtype);
  }

  public static implicit operator B(RMGRNT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RMGRNT({_gtype})";
  }
}

// RMNEWNS item
public class RMNEWNS : GLUEItem
{
  private readonly A _gtype;

  private RMNEWNS(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RMNEWNS(A gtype)
  {
    return new RMNEWNS(gtype);
  }

  public static implicit operator A(RMNEWNS gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RMNEWNS({_gtype})";
  }
}

// RMNSCMD item
public class RMNSCMD : GLUEItem
{
  private readonly U1 _gtype;

  private RMNSCMD(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RMNSCMD(U1 gtype)
  {
    return new RMNSCMD(gtype);
  }

  public static implicit operator U1(RMNSCMD gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RMNSCMD({_gtype})";
  }
}

// RMNSSPEC item
public class RMNSSPEC : GLUEItem
{
  private readonly A _gtype;

  private RMNSSPEC(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RMNSSPEC(A gtype)
  {
    return new RMNSSPEC(gtype);
  }

  public static implicit operator A(RMNSSPEC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RMNSSPEC({_gtype})";
  }
}

// RMRECSPEC item
public class RMRECSPEC : GLUEItem
{
  private readonly A _gtype;

  private RMRECSPEC(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RMRECSPEC(A gtype)
  {
    return new RMRECSPEC(gtype);
  }

  public static implicit operator A(RMRECSPEC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RMRECSPEC({_gtype})";
  }
}

// RMSEGSPEC item
public class RMSEGSPEC : GLUEItem
{
  private readonly A _gtype;

  private RMSEGSPEC(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RMSEGSPEC(A gtype)
  {
    return new RMSEGSPEC(gtype);
  }

  public static implicit operator A(RMSEGSPEC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RMSEGSPEC({_gtype})";
  }
}

// RMSPACE item
public class RMSPACE : GLUEItem
{
  private readonly U4 _gtype;

  private RMSPACE(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RMSPACE(U4 gtype)
  {
    return new RMSPACE(gtype);
  }

  public static implicit operator U4(RMSPACE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RMSPACE({_gtype})";
  }
}

// RMSPWD item
public class RMSPWD : GLUEItem
{
  private readonly A _gtype;

  private RMSPWD(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RMSPWD(A gtype)
  {
    return new RMSPWD(gtype);
  }

  public static implicit operator A(RMSPWD gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RMSPWD({_gtype})";
  }
}

// RMSUSERID item
public class RMSUSERID : GLUEItem
{
  private readonly A _gtype;

  private RMSUSERID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RMSUSERID(A gtype)
  {
    return new RMSUSERID(gtype);
  }

  public static implicit operator A(RMSUSERID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RMSUSERID({_gtype})";
  }
}

// ROWCT item
public class ROWCT : GLUEItem
{
  private readonly U4 _gtype;

  private ROWCT(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator ROWCT(U4 gtype)
  {
    return new ROWCT(gtype);
  }

  public static implicit operator U4(ROWCT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"ROWCT({_gtype})";
  }
}

// RPMACK item
public class RPMACK : GLUEItem
{
  private readonly U1 _gtype;

  private RPMACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RPMACK(U1 gtype)
  {
    return new RPMACK(gtype);
  }

  public static implicit operator U1(RPMACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RPMACK({_gtype})";
  }
}

// RPSEL item
public class RPSEL : GLUEItem
{
  private readonly U1 _gtype;

  private RPSEL(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RPSEL(U1 gtype)
  {
    return new RPSEL(gtype);
  }

  public static implicit operator U1(RPSEL gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RPSEL({_gtype})";
  }
}

// RPTID item
public class RPTID : GLUEItem
{
  private readonly U4 _gtype;

  private RPTID(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RPTID(U4 gtype)
  {
    return new RPTID(gtype);
  }

  public static implicit operator U4(RPTID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RPTID({_gtype})";
  }
}

// RPTOC item
public class RPTOC : GLUEItem
{
  private readonly TF _gtype;

  private RPTOC(TF gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RPTOC(TF gtype)
  {
    return new RPTOC(gtype);
  }

  public static implicit operator TF(RPTOC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RPTOC({_gtype})";
  }
}

// RQCMD item
public class RQCMD : GLUEItem
{
  private readonly TF _gtype;

  private RQCMD(TF gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RQCMD(TF gtype)
  {
    return new RQCMD(gtype);
  }

  public static implicit operator TF(RQCMD gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RQCMD({_gtype})";
  }
}

// RRACK item
public class RRACK : GLUEItem
{
  private readonly B _gtype;

  private RRACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RRACK(B gtype)
  {
    return new RRACK(gtype);
  }

  public static implicit operator B(RRACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RRACK({_gtype})";
  }
}

// RRACK_S20 item
public class RRACK_S20 : GLUEItem
{
  private readonly U1 _gtype;

  private RRACK_S20(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RRACK_S20(U1 gtype)
  {
    return new RRACK_S20(gtype);
  }

  public static implicit operator U1(RRACK_S20 gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RRACK_S20({_gtype})";
  }
}

// RSACK item
public class RSACK : GLUEItem
{
  private readonly B _gtype;

  private RSACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RSACK(B gtype)
  {
    return new RSACK(gtype);
  }

  public static implicit operator B(RSACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RSACK({_gtype})";
  }
}

// RSDA item
public class RSDA : GLUEItem
{
  private readonly B _gtype;

  private RSDA(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RSDA(B gtype)
  {
    return new RSDA(gtype);
  }

  public static implicit operator B(RSDA gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RSDA({_gtype})";
  }
}

// RSDC item
public class RSDC : GLUEItem
{
  private readonly U1 _gtype;

  private RSDC(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RSDC(U1 gtype)
  {
    return new RSDC(gtype);
  }

  public static implicit operator U1(RSDC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RSDC({_gtype})";
  }
}

// RSINF item
public class RSINF : GLUEItem
{
  private readonly I4 _gtype;

  private RSINF(I4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RSINF(I4 gtype)
  {
    return new RSINF(gtype);
  }

  public static implicit operator I4(RSINF gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RSINF({_gtype})";
  }
}

// RSPACK item
public class RSPACK : GLUEItem
{
  private readonly B _gtype;

  private RSPACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RSPACK(B gtype)
  {
    return new RSPACK(gtype);
  }

  public static implicit operator B(RSPACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RSPACK({_gtype})";
  }
}

// RTSRSPSTAT item
public class RTSRSPSTAT : GLUEItem
{
  private readonly U1 _gtype;

  private RTSRSPSTAT(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RTSRSPSTAT(U1 gtype)
  {
    return new RTSRSPSTAT(gtype);
  }

  public static implicit operator U1(RTSRSPSTAT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RTSRSPSTAT({_gtype})";
  }
}

// RTYPE item
public class RTYPE : GLUEItem
{
  private readonly U1 _gtype;

  private RTYPE(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RTYPE(U1 gtype)
  {
    return new RTYPE(gtype);
  }

  public static implicit operator U1(RTYPE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RTYPE({_gtype})";
  }
}

// RECID item
public class RECID : GLUEItem
{
  private readonly A _gtype;

  private RECID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator RECID(A gtype)
  {
    return new RECID(gtype);
  }

  public static implicit operator A(RECID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"RECID({_gtype})";
  }
}

// SDACK item
public class SDACK : GLUEItem
{
  private readonly B _gtype;

  private SDACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SDACK(B gtype)
  {
    return new SDACK(gtype);
  }

  public static implicit operator B(SDACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SDACK({_gtype})";
  }
}

// SDBIN item
public class SDBIN : GLUEItem
{
  private readonly B _gtype;

  private SDBIN(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SDBIN(B gtype)
  {
    return new SDBIN(gtype);
  }

  public static implicit operator B(SDBIN gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SDBIN({_gtype})";
  }
}

// SENDPSPSTAT item
public class SENDPSPSTAT : GLUEItem
{
  private readonly U1 _gtype;

  private SENDPSPSTAT(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SENDPSPSTAT(U1 gtype)
  {
    return new SENDPSPSTAT(gtype);
  }

  public static implicit operator U1(SENDPSPSTAT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SENDPSPSTAT({_gtype})";
  }
}

// SEQNUM item
public class SEQNUM : GLUEItem
{
  private readonly U4 _gtype;

  private SEQNUM(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SEQNUM(U4 gtype)
  {
    return new SEQNUM(gtype);
  }

  public static implicit operator U4(SEQNUM gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SEQNUM({_gtype})";
  }
}

// SFCD item
public class SFCD : GLUEItem
{
  private readonly B _gtype;

  private SFCD(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SFCD(B gtype)
  {
    return new SFCD(gtype);
  }

  public static implicit operator B(SFCD gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SFCD({_gtype})";
  }
}

// SHEAD item
public class SHEAD : GLUEItem
{
  private readonly B _gtype;

  private SHEAD(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SHEAD(B gtype)
  {
    return new SHEAD(gtype);
  }

  public static implicit operator B(SHEAD gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SHEAD({_gtype})";
  }
}

// SLOTID item
public class SLOTID : GLUEItem
{
  private readonly U1 _gtype;

  private SLOTID(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SLOTID(U1 gtype)
  {
    return new SLOTID(gtype);
  }

  public static implicit operator U1(SLOTID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SLOTID({_gtype})";
  }
}

// SMPLN item
public class SMPLN : GLUEItem
{
  private readonly U4 _gtype;

  private SMPLN(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SMPLN(U4 gtype)
  {
    return new SMPLN(gtype);
  }

  public static implicit operator U4(SMPLN gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SMPLN({_gtype})";
  }
}

// SOFTREV item
public class SOFTREV : GLUEItem
{
  private readonly A _gtype;

  private SOFTREV(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SOFTREV(A gtype)
  {
    return new SOFTREV(gtype);
  }

  public static implicit operator A(SOFTREV gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SOFTREV({_gtype})";
  }
}

// SPAACK item
public class SPAACK : GLUEItem
{
  private readonly U1 _gtype;

  private SPAACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SPAACK(U1 gtype)
  {
    return new SPAACK(gtype);
  }

  public static implicit operator U1(SPAACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SPAACK({_gtype})";
  }
}

// SPD item
public class SPD : GLUEItem
{
  private readonly B _gtype;

  private SPD(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SPD(B gtype)
  {
    return new SPD(gtype);
  }

  public static implicit operator B(SPD gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SPD({_gtype})";
  }
}

// SPID item
public class SPID : GLUEItem
{
  private readonly A _gtype;

  private SPID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SPID(A gtype)
  {
    return new SPID(gtype);
  }

  public static implicit operator A(SPID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SPID({_gtype})";
  }
}

// SPNAME item
public class SPNAME : GLUEItem
{
  private readonly A _gtype;

  private SPNAME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SPNAME(A gtype)
  {
    return new SPNAME(gtype);
  }

  public static implicit operator A(SPNAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SPNAME({_gtype})";
  }
}

// SPR item
public class SPR : GLUEItem
{
  private readonly A _gtype;

  private SPR(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SPR(A gtype)
  {
    return new SPR(gtype);
  }

  public static implicit operator A(SPR gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SPR({_gtype})";
  }
}

// SPVAL item
public class SPVAL : GLUEItem
{
  private readonly A _gtype;

  private SPVAL(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SPVAL(A gtype)
  {
    return new SPVAL(gtype);
  }

  public static implicit operator A(SPVAL gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SPVAL({_gtype})";
  }
}

// SSAACK item
public class SSAACK : GLUEItem
{
  private readonly U1 _gtype;

  private SSAACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SSAACK(U1 gtype)
  {
    return new SSAACK(gtype);
  }

  public static implicit operator U1(SSAACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SSAACK({_gtype})";
  }
}

// SSACK item
public class SSACK : GLUEItem
{
  private readonly A _gtype;

  private SSACK(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SSACK(A gtype)
  {
    return new SSACK(gtype);
  }

  public static implicit operator A(SSACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SSACK({_gtype})";
  }
}

// SSCMD item
public class SSCMD : GLUEItem
{
  private readonly A _gtype;

  private SSCMD(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SSCMD(A gtype)
  {
    return new SSCMD(gtype);
  }

  public static implicit operator A(SSCMD gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SSCMD({_gtype})";
  }
}

// STATUS item
public class STATUS : GLUEItem
{
  private readonly A _gtype;

  private STATUS(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator STATUS(A gtype)
  {
    return new STATUS(gtype);
  }

  public static implicit operator A(STATUS gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"STATUS({_gtype})";
  }
}

// STATUSTXT item
public class STATUSTXT : GLUEItem
{
  private readonly A _gtype;

  private STATUSTXT(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator STATUSTXT(A gtype)
  {
    return new STATUSTXT(gtype);
  }

  public static implicit operator A(STATUSTXT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"STATUSTXT({_gtype})";
  }
}

// STIME item
public class STIME : GLUEItem
{
  private readonly A _gtype;

  private STIME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator STIME(A gtype)
  {
    return new STIME(gtype);
  }

  public static implicit operator A(STIME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"STIME({_gtype})";
  }
}

// STRACK item
public class STRACK : GLUEItem
{
  private readonly B _gtype;

  private STRACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator STRACK(B gtype)
  {
    return new STRACK(gtype);
  }

  public static implicit operator B(STRACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"STRACK({_gtype})";
  }
}

// STRID item
public class STRID : GLUEItem
{
  private readonly U1 _gtype;

  private STRID(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator STRID(U1 gtype)
  {
    return new STRID(gtype);
  }

  public static implicit operator U1(STRID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"STRID({_gtype})";
  }
}

// STRP item
public class STRP : GLUEItem
{
  private readonly I2 _gtype;

  private STRP(I2 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator STRP(I2 gtype)
  {
    return new STRP(gtype);
  }

  public static implicit operator I2(STRP gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"STRP({_gtype})";
  }
}

// SV item
public class SV : GLUEItem
{
  private readonly A _gtype;

  private SV(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SV(A gtype)
  {
    return new SV(gtype);
  }

  public static implicit operator A(SV gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SV({_gtype})";
  }
}

// SV0 item
public class SV0 : GLUEItem
{
  private readonly A _gtype;

  private SV0(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SV0(A gtype)
  {
    return new SV0(gtype);
  }

  public static implicit operator A(SV0 gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SV0({_gtype})";
  }
}

// SVCACK item
public class SVCACK : GLUEItem
{
  private readonly B _gtype;

  private SVCACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SVCACK(B gtype)
  {
    return new SVCACK(gtype);
  }

  public static implicit operator B(SVCACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SVCACK({_gtype})";
  }
}

// SVCNAME item
public class SVCNAME : GLUEItem
{
  private readonly A _gtype;

  private SVCNAME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SVCNAME(A gtype)
  {
    return new SVCNAME(gtype);
  }

  public static implicit operator A(SVCNAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SVCNAME({_gtype})";
  }
}

// SVID item
public class SVID : GLUEItem
{
  private readonly U4 _gtype;

  private SVID(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SVID(U4 gtype)
  {
    return new SVID(gtype);
  }

  public static implicit operator U4(SVID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SVID({_gtype})";
  }
}

// SVNAME item
public class SVNAME : GLUEItem
{
  private readonly A _gtype;

  private SVNAME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator SVNAME(A gtype)
  {
    return new SVNAME(gtype);
  }

  public static implicit operator A(SVNAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"SVNAME({_gtype})";
  }
}

// TARGETID item
public class TARGETID : GLUEItem
{
  private readonly A _gtype;

  private TARGETID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TARGETID(A gtype)
  {
    return new TARGETID(gtype);
  }

  public static implicit operator A(TARGETID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TARGETID({_gtype})";
  }
}

// TARGETPDE item
public class TARGETPDE : GLUEItem
{
  private readonly A _gtype;

  private TARGETPDE(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TARGETPDE(A gtype)
  {
    return new TARGETPDE(gtype);
  }

  public static implicit operator A(TARGETPDE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TARGETPDE({_gtype})";
  }
}

// TARGETSPEC item
public class TARGETSPEC : GLUEItem
{
  private readonly A _gtype;

  private TARGETSPEC(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TARGETSPEC(A gtype)
  {
    return new TARGETSPEC(gtype);
  }

  public static implicit operator A(TARGETSPEC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TARGETSPEC({_gtype})";
  }
}

// TBLACK item
public class TBLACK : GLUEItem
{
  private readonly U1 _gtype;

  private TBLACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TBLACK(U1 gtype)
  {
    return new TBLACK(gtype);
  }

  public static implicit operator U1(TBLACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TBLACK({_gtype})";
  }
}

// TBLCMD item
public class TBLCMD : GLUEItem
{
  private readonly U1 _gtype;

  private TBLCMD(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TBLCMD(U1 gtype)
  {
    return new TBLCMD(gtype);
  }

  public static implicit operator U1(TBLCMD gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TBLCMD({_gtype})";
  }
}

// TBLELT item
public class TBLELT : GLUEItem
{
  private readonly A _gtype;

  private TBLELT(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TBLELT(A gtype)
  {
    return new TBLELT(gtype);
  }

  public static implicit operator A(TBLELT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TBLELT({_gtype})";
  }
}

// TBLID item
public class TBLID : GLUEItem
{
  private readonly A _gtype;

  private TBLID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TBLID(A gtype)
  {
    return new TBLID(gtype);
  }

  public static implicit operator A(TBLID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TBLID({_gtype})";
  }
}

// TBLTYP item
public class TBLTYP : GLUEItem
{
  private readonly A _gtype;

  private TBLTYP(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TBLTYP(A gtype)
  {
    return new TBLTYP(gtype);
  }

  public static implicit operator A(TBLTYP gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TBLTYP({_gtype})";
  }
}

// TCID item
public class TCID : GLUEItem
{
  private readonly A _gtype;

  private TCID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TCID(A gtype)
  {
    return new TCID(gtype);
  }

  public static implicit operator A(TCID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TCID({_gtype})";
  }
}

// TEXT item
public class TEXT : GLUEItem
{
  private readonly A _gtype;

  private TEXT(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TEXT(A gtype)
  {
    return new TEXT(gtype);
  }

  public static implicit operator A(TEXT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TEXT({_gtype})";
  }
}

// TIAACK item
public class TIAACK : GLUEItem
{
  private readonly B _gtype;

  private TIAACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TIAACK(B gtype)
  {
    return new TIAACK(gtype);
  }

  public static implicit operator B(TIAACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TIAACK({_gtype})";
  }
}

// TID item
public class TID : GLUEItem
{
  private readonly B _gtype;

  private TID(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TID(B gtype)
  {
    return new TID(gtype);
  }

  public static implicit operator B(TID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TID({_gtype})";
  }
}

// TIME item
public class TIME : GLUEItem
{
  private readonly A _gtype;

  private TIME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TIME(A gtype)
  {
    return new TIME(gtype);
  }

  public static implicit operator A(TIME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TIME({_gtype})";
  }
}

// TIMESTAMP item
public class TIMESTAMP : GLUEItem
{
  private readonly A _gtype;

  private TIMESTAMP(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TIMESTAMP(A gtype)
  {
    return new TIMESTAMP(gtype);
  }

  public static implicit operator A(TIMESTAMP gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TIMESTAMP({_gtype})";
  }
}

// TOTSMP item
public class TOTSMP : GLUEItem
{
  private readonly U4 _gtype;

  private TOTSMP(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TOTSMP(U4 gtype)
  {
    return new TOTSMP(gtype);
  }

  public static implicit operator U4(TOTSMP gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TOTSMP({_gtype})";
  }
}

// TRACK item
public class TRACK : GLUEItem
{
  private readonly TF _gtype;

  private TRACK(TF gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TRACK(TF gtype)
  {
    return new TRACK(gtype);
  }

  public static implicit operator TF(TRACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TRACK({_gtype})";
  }
}

// TRANSFERSIZE item
public class TRANSFERSIZE : GLUEItem
{
  private readonly U8 _gtype;

  private TRANSFERSIZE(U8 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TRANSFERSIZE(U8 gtype)
  {
    return new TRANSFERSIZE(gtype);
  }

  public static implicit operator U8(TRANSFERSIZE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TRANSFERSIZE({_gtype})";
  }
}

// TRATOMCID item
public class TRATOMCID : GLUEItem
{
  private readonly U4 _gtype;

  private TRATOMCID(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TRATOMCID(U4 gtype)
  {
    return new TRATOMCID(gtype);
  }

  public static implicit operator U4(TRATOMCID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TRATOMCID({_gtype})";
  }
}

// TRAUTOD item
public class TRAUTOD : GLUEItem
{
  private readonly TF _gtype;

  private TRAUTOD(TF gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TRAUTOD(TF gtype)
  {
    return new TRAUTOD(gtype);
  }

  public static implicit operator TF(TRAUTOD gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TRAUTOD({_gtype})";
  }
}

// TRAUTOSTART item
public class TRAUTOSTART : GLUEItem
{
  private readonly TF _gtype;

  private TRAUTOSTART(TF gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TRAUTOSTART(TF gtype)
  {
    return new TRAUTOSTART(gtype);
  }

  public static implicit operator TF(TRAUTOSTART gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TRAUTOSTART({_gtype})";
  }
}

// TRCMDNAME item
public class TRCMDNAME : GLUEItem
{
  private readonly A _gtype;

  private TRCMDNAME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TRCMDNAME(A gtype)
  {
    return new TRCMDNAME(gtype);
  }

  public static implicit operator A(TRCMDNAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TRCMDNAME({_gtype})";
  }
}

// TRDIR item
public class TRDIR : GLUEItem
{
  private readonly U1 _gtype;

  private TRDIR(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TRDIR(U1 gtype)
  {
    return new TRDIR(gtype);
  }

  public static implicit operator U1(TRDIR gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TRDIR({_gtype})";
  }
}

// TRID item
public class TRID : GLUEItem
{
  private readonly A _gtype;

  private TRID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TRID(A gtype)
  {
    return new TRID(gtype);
  }

  public static implicit operator A(TRID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TRID({_gtype})";
  }
}

// TRJOBID item
public class TRJOBID : GLUEItem
{
  private readonly B _gtype;

  private TRJOBID(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TRJOBID(B gtype)
  {
    return new TRJOBID(gtype);
  }

  public static implicit operator B(TRJOBID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TRJOBID({_gtype})";
  }
}

// TRJOBMS item
public class TRJOBMS : GLUEItem
{
  private readonly U1 _gtype;

  private TRJOBMS(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TRJOBMS(U1 gtype)
  {
    return new TRJOBMS(gtype);
  }

  public static implicit operator U1(TRJOBMS gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TRJOBMS({_gtype})";
  }
}

// TRJOBNAME item
public class TRJOBNAME : GLUEItem
{
  private readonly A _gtype;

  private TRJOBNAME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TRJOBNAME(A gtype)
  {
    return new TRJOBNAME(gtype);
  }

  public static implicit operator A(TRJOBNAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TRJOBNAME({_gtype})";
  }
}

// TRLINK item
public class TRLINK : GLUEItem
{
  private readonly U4 _gtype;

  private TRLINK(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TRLINK(U4 gtype)
  {
    return new TRLINK(gtype);
  }

  public static implicit operator U4(TRLINK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TRLINK({_gtype})";
  }
}

// TRLOCATION item
public class TRLOCATION : GLUEItem
{
  private readonly U4 _gtype;

  private TRLOCATION(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TRLOCATION(U4 gtype)
  {
    return new TRLOCATION(gtype);
  }

  public static implicit operator U4(TRLOCATION gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TRLOCATION({_gtype})";
  }
}

// TROBJNAME item
public class TROBJNAME : GLUEItem
{
  private readonly A _gtype;

  private TROBJNAME(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TROBJNAME(A gtype)
  {
    return new TROBJNAME(gtype);
  }

  public static implicit operator A(TROBJNAME gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TROBJNAME({_gtype})";
  }
}

// TROBJTYPE item
public class TROBJTYPE : GLUEItem
{
  private readonly U4 _gtype;

  private TROBJTYPE(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TROBJTYPE(U4 gtype)
  {
    return new TROBJTYPE(gtype);
  }

  public static implicit operator U4(TROBJTYPE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TROBJTYPE({_gtype})";
  }
}

// TRPORT item
public class TRPORT : GLUEItem
{
  private readonly U4 _gtype;

  private TRPORT(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TRPORT(U4 gtype)
  {
    return new TRPORT(gtype);
  }

  public static implicit operator U4(TRPORT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TRPORT({_gtype})";
  }
}

// TRPTNR item
public class TRPTNR : GLUEItem
{
  private readonly A _gtype;

  private TRPTNR(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TRPTNR(A gtype)
  {
    return new TRPTNR(gtype);
  }

  public static implicit operator A(TRPTNR gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TRPTNR({_gtype})";
  }
}

// TRPTPORT item
public class TRPTPORT : GLUEItem
{
  private readonly U4 _gtype;

  private TRPTPORT(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TRPTPORT(U4 gtype)
  {
    return new TRPTPORT(gtype);
  }

  public static implicit operator U4(TRPTPORT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TRPTPORT({_gtype})";
  }
}

// TRRCP item
public class TRRCP : GLUEItem
{
  private readonly A _gtype;

  private TRRCP(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TRRCP(A gtype)
  {
    return new TRRCP(gtype);
  }

  public static implicit operator A(TRRCP gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TRRCP({_gtype})";
  }
}

// TRROLE item
public class TRROLE : GLUEItem
{
  private readonly U1 _gtype;

  private TRROLE(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TRROLE(U1 gtype)
  {
    return new TRROLE(gtype);
  }

  public static implicit operator U1(TRROLE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TRROLE({_gtype})";
  }
}

// TRTYPE item
public class TRTYPE : GLUEItem
{
  private readonly U1 _gtype;

  private TRTYPE(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TRTYPE(U1 gtype)
  {
    return new TRTYPE(gtype);
  }

  public static implicit operator U1(TRTYPE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TRTYPE({_gtype})";
  }
}

// TSIP item
public class TSIP : GLUEItem
{
  private readonly B _gtype;

  private TSIP(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TSIP(B gtype)
  {
    return new TSIP(gtype);
  }

  public static implicit operator B(TSIP gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TSIP({_gtype})";
  }
}

// TSOP item
public class TSOP : GLUEItem
{
  private readonly B _gtype;

  private TSOP(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TSOP(B gtype)
  {
    return new TSOP(gtype);
  }

  public static implicit operator B(TSOP gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TSOP({_gtype})";
  }
}

// TTC item
public class TTC : GLUEItem
{
  private readonly U4 _gtype;

  private TTC(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TTC(U4 gtype)
  {
    return new TTC(gtype);
  }

  public static implicit operator U4(TTC gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TTC({_gtype})";
  }
}

// TYPEID item
public class TYPEID : GLUEItem
{
  private readonly U1 _gtype;

  private TYPEID(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator TYPEID(U1 gtype)
  {
    return new TYPEID(gtype);
  }

  public static implicit operator U1(TYPEID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"TYPEID({_gtype})";
  }
}

// UID item
public class UID : GLUEItem
{
  private readonly A _gtype;

  private UID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator UID(A gtype)
  {
    return new UID(gtype);
  }

  public static implicit operator A(UID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"UID({_gtype})";
  }
}

// UNFLEN item
public class UNFLEN : GLUEItem
{
  private readonly U4 _gtype;

  private UNFLEN(U4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator UNFLEN(U4 gtype)
  {
    return new UNFLEN(gtype);
  }

  public static implicit operator U4(UNFLEN gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"UNFLEN({_gtype})";
  }
}

// UNITS item
public class UNITS : GLUEItem
{
  private readonly A _gtype;

  private UNITS(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator UNITS(A gtype)
  {
    return new UNITS(gtype);
  }

  public static implicit operator A(UNITS gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"UNITS({_gtype})";
  }
}

// UPPERDB item
public class UPPERDB : GLUEItem
{
  private readonly F4 _gtype;

  private UPPERDB(F4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator UPPERDB(F4 gtype)
  {
    return new UPPERDB(gtype);
  }

  public static implicit operator F4(UPPERDB gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"UPPERDB({_gtype})";
  }
}

// V item
public class V : GLUEItem
{
  private readonly A _gtype;

  private V(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator V(A gtype)
  {
    return new V(gtype);
  }

  public static implicit operator A(V gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"V({_gtype})";
  }
}

// VERID item
public class VERID : GLUEItem
{
  private readonly A _gtype;

  private VERID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator VERID(A gtype)
  {
    return new VERID(gtype);
  }

  public static implicit operator A(VERID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"VERID({_gtype})";
  }
}

// VERIFYDEPTH item
public class VERIFYDEPTH : GLUEItem
{
  private readonly U1 _gtype;

  private VERIFYDEPTH(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator VERIFYDEPTH(U1 gtype)
  {
    return new VERIFYDEPTH(gtype);
  }

  public static implicit operator U1(VERIFYDEPTH gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"VERIFYDEPTH({_gtype})";
  }
}

// VERIFYRSPSTAT item
public class VERIFYRSPSTAT : GLUEItem
{
  private readonly U1 _gtype;

  private VERIFYRSPSTAT(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator VERIFYRSPSTAT(U1 gtype)
  {
    return new VERIFYRSPSTAT(gtype);
  }

  public static implicit operator U1(VERIFYRSPSTAT gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"VERIFYRSPSTAT({_gtype})";
  }
}

// VERIFYSUCCESS item
public class VERIFYSUCCESS : GLUEItem
{
  private readonly TF _gtype;

  private VERIFYSUCCESS(TF gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator VERIFYSUCCESS(TF gtype)
  {
    return new VERIFYSUCCESS(gtype);
  }

  public static implicit operator TF(VERIFYSUCCESS gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"VERIFYSUCCESS({_gtype})";
  }
}

// VERIFYTYPE item
public class VERIFYTYPE : GLUEItem
{
  private readonly U1 _gtype;

  private VERIFYTYPE(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator VERIFYTYPE(U1 gtype)
  {
    return new VERIFYTYPE(gtype);
  }

  public static implicit operator U1(VERIFYTYPE gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"VERIFYTYPE({_gtype})";
  }
}

// VID item
public class VID : GLUEItem
{
  private readonly A _gtype;

  private VID(A gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator VID(A gtype)
  {
    return new VID(gtype);
  }

  public static implicit operator A(VID gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"VID({_gtype})";
  }
}

// VLAACK item
public class VLAACK : GLUEItem
{
  private readonly B _gtype;

  private VLAACK(B gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator VLAACK(B gtype)
  {
    return new VLAACK(gtype);
  }

  public static implicit operator B(VLAACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"VLAACK({_gtype})";
  }
}

// WRACK item
public class WRACK : GLUEItem
{
  private readonly U1 _gtype;

  private WRACK(U1 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator WRACK(U1 gtype)
  {
    return new WRACK(gtype);
  }

  public static implicit operator U1(WRACK gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"WRACK({_gtype})";
  }
}

// XDIES item
public class XDIES : GLUEItem
{
  private readonly F4 _gtype;

  private XDIES(F4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator XDIES(F4 gtype)
  {
    return new XDIES(gtype);
  }

  public static implicit operator F4(XDIES gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"XDIES({_gtype})";
  }
}

// XYPOS item
public class XYPOS : GLUEItem
{
  private readonly I2 _gtype;

  private XYPOS(I2 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator XYPOS(I2 gtype)
  {
    return new XYPOS(gtype);
  }

  public static implicit operator I2(XYPOS gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"XYPOS({_gtype})";
  }
}

// YDIES item
public class YDIES : GLUEItem
{
  private readonly F4 _gtype;

  private YDIES(F4 gtype)
  {
    _gtype = gtype;
  }

  public static implicit operator YDIES(F4 gtype)
  {
    return new YDIES(gtype);
  }

  public static implicit operator F4(YDIES gitem)
  {
    return gitem._gtype;
  }

  public override string ToString()
  {
    return $"YDIES({_gtype})";
  }
}