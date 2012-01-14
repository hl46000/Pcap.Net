﻿namespace PcapDotNet.Packets.Dns
{
    /// <summary>
    /// RFCs 1035, 1183, 1348, 1706, 1712, 1876, 1995, 2163, 2168, 2230, 2535, 2672, 2782, 2845, 2874, 2915, 2930, 3123, 3226, 3403, 3596, 3658, 3755, 4025, 
    /// 4034, 4255, 4398, 4408, 4431, 4701, 5155, 5205, 5864, 5936.
    /// Other sources: ATMDOC, Barwood, Eastlake, Faltstrom, Hallam-Baker, PATTON, Reid, Weiler, Wijngaards.
    /// Type fields are used in resource records.
    /// </summary>
    public enum DnsType : ushort
    {
        /// <summary>
        /// RFC 1035.
        /// A host address.
        /// Payload type: DnsResourceDataIpV4.
        /// </summary>
        A = 1,

        /// <summary>
        /// RFC 1035.
        /// An authoritative name server.
        /// Payload type: DnsResourceDataDomainName.
        /// </summary>
        Ns = 2,

        /// <summary>
        /// RFC 1035.
        /// A mail destination (Obsolete - use MX).
        /// Payload type: DnsResourceDataDomainName.
        /// </summary>
        Md = 3,

        /// <summary>
        /// RFC 1035.
        /// A mail forwarder (Obsolete - use MX).
        /// Payload type: DnsResourceDataDomainName.
        /// </summary>
        Mf = 4,

        /// <summary>
        /// RFC 1035.
        /// The canonical name for an alias.
        /// Payload type: DnsResourceDataDomainName.
        /// </summary>
        CName = 5,
        
        /// <summary>
        /// RFC 1035.
        /// Marks the start of a zone of authority.
        /// Payload type: DnsResourceDataStartOfAuthority.
        /// </summary>
        Soa = 6,

        /// <summary>
        /// RFC 1035.
        /// A mailbox domain name (EXPERIMENTAL).
        /// Payload type: DnsResourceDataDomainName.
        /// </summary>
        Mb = 7,

        /// <summary>
        /// RFC 1035.
        /// A mail group member (EXPERIMENTAL).
        /// Payload type: DnsResourceDataDomainName.
        /// </summary>
        Mg = 8,

        /// <summary>
        /// RFC 1035.
        /// A mail rename domain name (EXPERIMENTAL).
        /// Payload type: DnsResourceDataDomainName.
        /// </summary>
        Mr = 9,

        /// <summary>
        /// RFC 1035.
        /// A null RR (EXPERIMENTAL).
        /// Payload type: DnsResourceDataAnything.
        /// </summary>
        Null = 10,

        /// <summary>
        /// RFC 1035.
        /// A well known service description..
        /// Payload type: DnsResourceDataWellKnownService.
        /// </summary>
        Wks = 11,

        /// <summary>
        /// RFC 1035.
        /// A domain name pointer.
        /// Payload type: DnsResourceDataDomainName.
        /// </summary>
        Ptr = 12,

        /// <summary>
        /// RFC 1035.
        /// Host information.
        /// Payload type: DnsResourceDataHostInformation.
        /// </summary>
        HInfo = 13,

        /// <summary>
        /// RFC 1035.
        /// mailbox or mail list information.
        /// Payload type: DnsResourceDataMailingListInfo.
        /// </summary>
        MInfo = 14,

        /// <summary>
        /// RFC 1035.
        /// Mail exchange.
        /// Payload type: DnsResourceDataMailExchange.
        /// </summary>
        Mx = 15,

        /// <summary>
        /// RFC 1035.
        /// Text strings.
        /// Payload type: DnsResourceDataText.
        /// </summary>
        Txt = 16,

        /// <summary>
        /// RFC 1183.
        /// For Responsible Person.
        /// Payload type: DnsResourceDataResponsiblePerson.
        /// </summary>
        Rp = 17,

        /// <summary>
        /// RFCs 1183, 5864.
        /// For AFS Data Base location.
        /// Payload type: DnsResourceDataAfsDb.
        /// </summary>
        AfsDb = 18,

        /// <summary>
        /// RFC 1183.
        /// For X.25 PSDN address.
        /// Payload type: DnsResourceDataString.
        /// </summary>
        X25 = 19,

        /// <summary>
        /// RFC 1183.
        /// For ISDN address.
        /// Payload type: DnsResourceDataIsdn.
        /// </summary>
        Isdn = 20,

        /// <summary>
        /// RFC 1183.
        /// For Route Through.
        /// Payload type: DnsResourceDataRouteThrough.
        /// </summary>
        Rt = 21,

        /// <summary>
        /// RFC 1706.
        /// Network Service Access Point.
        /// For NSAP address, NSAP style A record.
        /// Payload type: DnsResourceDataNetworkServiceAccessPoint.
        /// </summary>
        Nsap = 22,

        /// <summary>
        /// RFC 1348.
        /// For domain name pointer, NSAP style.
        /// Payload type: DnsResourceDataDomainName.
        /// </summary>
        NsapPtr = 23,

        /// <summary>
        /// RFCs 2535, 3755, 4034.
        /// For security signature.
        /// Payload type: DnsResourceDataSig.
        /// </summary>
        Sig = 24, 

        /// <summary>
        /// RFCs 2065, 2535, 3755, 4034.
        /// For security key.
        /// Payload type: DnsResourceDataKey.
        /// </summary>
        Key = 25,

        /// <summary>
        /// RFC 2163.
        /// X.400 mail mapping information.
        /// Payload type: DnsResourceDataX400Pointer.
        /// </summary>
        Px = 26, 

        /// <summary>
        /// RFC 1712.
        /// Geographical Position.
        /// Payload type: DnsResourceDataGeographicalPosition.
        /// </summary>
        GPos = 27,

        /// <summary>
        /// RFC 3596.
        /// IP6 Address.
        /// Payload type: DnsResourceDataIpV6.
        /// </summary>
        Aaaa = 28,

        /// <summary>
        /// RFC 1876.
        /// Location Information.
        /// Payload type: DnsResourceDataLocationInformation.
        /// </summary>
        Loc = 29,

        /// <summary>
        /// RFC 2535, 3755.
        /// Next Domain - OBSOLETE.
        /// Payload type: DnsResourceDataNextDomain.
        /// </summary>
        Nxt = 30,

        /// <summary>
        /// Patton.
        /// Nimrod Endpoint Identifier.
        /// Payload type: DnsResourceDataAnything.
        /// </summary>
        EId = 31,

        /// <summary>
        /// Patton.
        /// Nimrod Locator.
        /// Payload type: DnsResourceDataAnything.
        /// </summary>
        NimLoc = 32,

        /// <summary>
        /// RFC 2782.
        /// Server Selection.
        /// Payload type: DnsResourceDataServerSelection.
        /// </summary>
        Srv = 33,

        /// <summary>
        /// ATMDOC.
        /// ATM Address.
        /// Payload type: DnsResourceDataAtmAddress.
        /// </summary>
        AtmA = 34,

        /// <summary>
        /// RFCs 2168, 2915, 3403.
        /// Naming Authority Pointer.
        /// Payload type: DnsResourceDataNamingAuthorityPointer.
        /// </summary>
        NaPtr = 35,

        /// <summary>
        /// RFC 2230.
        /// Key Exchanger.
        /// Payload type: DnsResourceDataKeyExchanger.
        /// </summary>
        Kx = 36,

        /// <summary>
        /// RFC 4398.
        /// CERT.
        /// Payload type: DnsResourceDataCertificate.
        /// </summary>
        Cert = 37,

        /// <summary>
        /// RFCs 2874, 3226.
        /// A6 (Experimental).
        /// Payload type: DnsResourceDataA6.
        /// </summary>
        A6 = 38,
        
        /// <summary>
        /// RFC 2672.
        /// DNAME.
        /// Payload type: DnsResourceDataDomainName.
        /// </summary>
        DName = 39,

        /// <summary>
        /// Eastlake.
        /// SINK.
        /// Payload type: DnsResourceDataSink.
        /// </summary>
        Sink = 40,

        /// <summary>
        /// RFC 2671.
        /// OPT.
        /// Payload type: DnsResourceDataOptions.
        /// </summary>
        Opt = 41,

        /// <summary>
        /// RFC 3123.
        /// Address Prefix List.
        /// Payload type: DnsResourceDataAddressPrefixList.
        /// </summary>
        Apl = 42,

        /// <summary>
        /// RFCs 3658, 4034.
        /// Delegation Signer.
        /// Payload type: DnsResourceDataDelegationSigner.
        /// </summary>
        Ds = 43,

        /// <summary>
        /// RFC 4255.
        /// SSH Key Fingerprint.
        /// Used to store a fingerprint of an SSH public host key that is associated with a Domain Name System (DNS) name.
        /// Payload type: DnsResourceDataSshFingerprint.
        /// </summary>
        SshFp = 44,

        /// <summary>
        /// RFC 4025.
        /// IPSECKEY.
        /// Payload type: DnsResourceDataIpSecKey.
        /// </summary>
        IpSecKey = 45,

        /// <summary>
        /// RFCs 3755, 4034.
        /// RRSIG.
        /// Payload type: DnsResourceDataSig.
        /// </summary>
        RrSig = 46,

        /// <summary>
        /// RFCs 3755, 4034.
        /// NSEC.
        /// Payload type: DnsResourceDataNextDomainSecure.
        /// </summary>
        NSec = 47,

        /// <summary>
        /// RFCs 3755, 4034, 5011.
        /// DNSKEY.
        /// Represents the public key.
        /// Payload type: DnsResourceDataDnsKey.
        /// </summary>
        DnsKey = 48,

        /// <summary>
        /// RFC 4701.
        /// DHCID.
        /// Dynamic Host Configuration Information.
        /// Payload type: DnsResourceDataAnything.
        /// </summary>
        Dhcid = 49,

        /// <summary>
        /// RFC 5155.
        /// NSEC3.
        /// Payload type: DnsResourceDataNextDomainSecure3.
        /// </summary>
        NSec3 = 50,

        /// <summary>
        /// RFC 5155.
        /// NSEC3PARAM.
        /// Payload type: DnsResourceDataNextDomainSecure3Parameters.
        /// </summary>
        NSec3Param = 51,

        /// <summary>
        /// RFC 5205.
        /// Host Identity Protocol.
        /// Payload type: DnsResourceDataHostIdentityProtocol.
        /// </summary>
        Hip = 55,

        /// <summary>
        /// Reid.
        /// NINFO.
        /// Payload type: DnsResourceDataNInfo.
        /// </summary>
        NInfo = 56,

        /// <summary>
        /// Reid.
        /// RKEY.
        /// Can be used to encrypt NAPTR record.
        /// Payload type: DnsResourceDataRKey.
        /// </summary>
        RKey = 57,

        /// <summary>
        /// Wijngaards.
        /// DNSSEC Trust Anchor LINK.
        /// Payload type: DnsResourceDataTrustAnchorLink.
        /// </summary>
        TaLink = 58,

        /// <summary>
        /// Barwood.
        /// Child DS.
        /// Payload type: DnsResourceDataDelegationSigner.
        /// </summary>
        Cds = 59,

        /// <summary>
        /// RFC 4408.
        /// Sender Policy Framework.
        /// Payload type: DnsResourceDataText.
        /// </summary>
        Spf = 99,

        /// <summary>
        /// IANA-Reserved.
        /// Not documented.
        /// </summary>
        UInfo = 100,

        /// <summary>
        /// IANA-Reserved.
        /// Not documented.
        /// </summary>
        Uid = 101,

        /// <summary>
        /// IANA-Reserved.
        /// Not documented.
        /// </summary>
        Gid = 102,

        /// <summary>
        /// IANA-Reserved.
        /// Not documented.
        /// </summary>
        UnSpec = 103,

        /// <summary>
        /// RFC 2930.
        /// Transaction Key.
        /// Payload type: DnsResourceDataTransactionKey.
        /// </summary>
        TKey = 249,

        /// <summary>
        /// RFC 2845.
        /// Transaction Signature.
        /// Payload type: DnsResourceDataTransactionSignature.
        /// </summary>
        TSig = 250,

        /// <summary>
        /// RFC 1995.
        /// Incremental transfer.
        /// Query Type.
        /// </summary>
        Ixfr = 251,

        /// <summary>
        /// RFCs 1035, 5936.
        /// Transfer of an entire zone.
        /// Query Type.
        /// </summary>
        Axfr = 252,

        /// <summary>
        /// RFC 1035.
        /// Mailbox-related RRs (MB, MG or MR).
        /// Query Type.
        /// </summary>
        MailB = 253,

        /// <summary>
        /// RFC 1035.
        /// Mail agent RRs (Obsolete - see MX).
        /// Query Type.
        /// </summary>
        MailA = 254,

        /// <summary>
        /// *.
        /// A request for all records
        /// Query Type.
        /// </summary>
        Any = 255,

        /// <summary>
        /// Faltstrom.
        /// URI.
        /// Payload type: DnsResourceDataUri.
        /// </summary>
        Uri = 256,

        /// <summary>
        /// Hallam-Baker.
        /// Certification Authority Authorization.
        /// Payload type: DnsResourceDataCertificationAuthorityAuthorization.
        /// </summary>
        Caa = 257,

        /// <summary>
        /// Weiler. 2005-12-13.
        /// DNSSEC Trust Authorities or Trust Anchor.
        /// Payload type: DnsResourceDataDelegationSigner.
        /// </summary>
        Ta = 32768,

        /// <summary>
        /// RFC 4431.
        /// DNSSEC Lookaside Validation.
        /// Payload type: DnsResourceDataDelegationSigner.
        /// </summary>
        Dlv = 32769,
    }
}