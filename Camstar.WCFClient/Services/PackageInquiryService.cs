// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PackageInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PackageInquiryService : ChangePackageInquiryBase
  {
    public PackageInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPackageInquiryService), userProfile);
    }

    public ResultStatus GetPackages(
      PackageInquiry packageInquiry,
      PackageInquiry_Parameters parameters,
      PackageInquiry_Request request,
      out PackageInquiry_Result result)
    {
      result = (PackageInquiry_Result) null;
      this.OnBeforeCall(nameof (GetPackages), (DCObject) packageInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageInquiryService) this._Channel).GetPackages(this._UserProfile, packageInquiry, parameters, request, out result) : this.AddMethod((Method) new PackageInquiryMethod(packageInquiry, PackageInquiryMethods.GetPackages, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetPackages), res, (DCObject) packageInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetPackages()
    {
      return this.GetPackages((PackageInquiry) null, (PackageInquiry_Parameters) null, (PackageInquiry_Request) null, out PackageInquiry_Result _);
    }

    public ResultStatus GetPackages(PackageInquiry packageInquiry)
    {
      return this.GetPackages(packageInquiry, (PackageInquiry_Parameters) null, (PackageInquiry_Request) null, out PackageInquiry_Result _);
    }

    public ResultStatus GetPackages(
      PackageInquiry packageInquiry,
      PackageInquiry_Request request,
      out PackageInquiry_Result result)
    {
      return this.GetPackages(packageInquiry, (PackageInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PackageInquiry packageInquiry,
      PackageInquiry_Parameters parameters,
      PackageInquiry_Request request,
      out PackageInquiry_Result result)
    {
      result = (PackageInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) packageInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, packageInquiry, parameters, request, out result) : this.AddMethod((Method) new PackageInquiryMethod(packageInquiry, PackageInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) packageInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PackageInquiry) null, (PackageInquiry_Parameters) null, (PackageInquiry_Request) null, out PackageInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(PackageInquiry packageInquiry)
    {
      return this.GetWIPMsgs(packageInquiry, (PackageInquiry_Parameters) null, (PackageInquiry_Request) null, out PackageInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PackageInquiry packageInquiry,
      PackageInquiry_Request request,
      out PackageInquiry_Result result)
    {
      return this.GetWIPMsgs(packageInquiry, (PackageInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject packageInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PackageInquiry) packageInquiry, (PackageInquiry_Parameters) parameters, (PackageInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PackageInquiry_Request request,
      out PackageInquiry_Result result)
    {
      result = (PackageInquiry_Result) null;
      try
      {
        PackageInquiryMethod[] methods = new PackageInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPackageInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PackageInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PackageInquiry cdo,
      PackageInquiry_Request request,
      out PackageInquiry_Result result)
    {
      result = (PackageInquiry_Result) null;
      try
      {
        return ((IPackageInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((PackageInquiry) cdo, (PackageInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PackageInquiry_Request request,
      out PackageInquiry_Result result)
    {
      return this.GetEnvironment((PackageInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PackageInquiry cdo,
      PackageInquiry_Request request,
      out PackageInquiry_Result result)
    {
      result = (PackageInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PackageInquiryMethod(cdo, PackageInquiryMethods.ExecuteTransaction, (PackageInquiry_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PackageInquiry) cdo, (PackageInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PackageInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (PackageInquiry_Request) null, out PackageInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PackageInquiry_Request request,
      out PackageInquiry_Result result)
    {
      return this.ExecuteTransaction((PackageInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PackageInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PackageInquiryMethod(cdo, PackageInquiryMethods.AddDataTransaction, (PackageInquiry_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((PackageInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
