// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PackageCreationTemplateMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PackageCreationTemplateMaintService : NamedDataObjectMaintBase
  {
    public PackageCreationTemplateMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPackageCreationTemplateMaintService), userProfile);
    }

    public ResultStatus Delete(
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Parameters parameters,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      result = (PackageCreationTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) packageCreationTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageCreationTemplateMaintService) this._Channel).Delete(this._UserProfile, packageCreationTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PackageCreationTemplateMaintMethod(packageCreationTemplateMaint, PackageCreationTemplateMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) packageCreationTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((PackageCreationTemplateMaint) null, (PackageCreationTemplateMaint_Parameters) null, (PackageCreationTemplateMaint_Request) null, out PackageCreationTemplateMaint_Result _);
    }

    public ResultStatus Delete(
      PackageCreationTemplateMaint packageCreationTemplateMaint)
    {
      return this.Delete(packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) null, (PackageCreationTemplateMaint_Request) null, out PackageCreationTemplateMaint_Result _);
    }

    public ResultStatus Delete(
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      return this.Delete(packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Parameters parameters,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      result = (PackageCreationTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) packageCreationTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageCreationTemplateMaintService) this._Channel).Freeze(this._UserProfile, packageCreationTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PackageCreationTemplateMaintMethod(packageCreationTemplateMaint, PackageCreationTemplateMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) packageCreationTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((PackageCreationTemplateMaint) null, (PackageCreationTemplateMaint_Parameters) null, (PackageCreationTemplateMaint_Request) null, out PackageCreationTemplateMaint_Result _);
    }

    public ResultStatus Freeze(
      PackageCreationTemplateMaint packageCreationTemplateMaint)
    {
      return this.Freeze(packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) null, (PackageCreationTemplateMaint_Request) null, out PackageCreationTemplateMaint_Result _);
    }

    public ResultStatus Freeze(
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      return this.Freeze(packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Parameters parameters,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      result = (PackageCreationTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) packageCreationTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageCreationTemplateMaintService) this._Channel).GetWIPMsgs(this._UserProfile, packageCreationTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PackageCreationTemplateMaintMethod(packageCreationTemplateMaint, PackageCreationTemplateMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) packageCreationTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PackageCreationTemplateMaint) null, (PackageCreationTemplateMaint_Parameters) null, (PackageCreationTemplateMaint_Request) null, out PackageCreationTemplateMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PackageCreationTemplateMaint packageCreationTemplateMaint)
    {
      return this.GetWIPMsgs(packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) null, (PackageCreationTemplateMaint_Request) null, out PackageCreationTemplateMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      return this.GetWIPMsgs(packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Parameters parameters,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      result = (PackageCreationTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) packageCreationTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageCreationTemplateMaintService) this._Channel).Load(this._UserProfile, packageCreationTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PackageCreationTemplateMaintMethod(packageCreationTemplateMaint, PackageCreationTemplateMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) packageCreationTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PackageCreationTemplateMaint) null, (PackageCreationTemplateMaint_Parameters) null, (PackageCreationTemplateMaint_Request) null, out PackageCreationTemplateMaint_Result _);
    }

    public ResultStatus Load(
      PackageCreationTemplateMaint packageCreationTemplateMaint)
    {
      return this.Load(packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) null, (PackageCreationTemplateMaint_Request) null, out PackageCreationTemplateMaint_Result _);
    }

    public ResultStatus Load(
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      return this.Load(packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_LoadESigDetails_Parameters parameters,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      result = (PackageCreationTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) packageCreationTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageCreationTemplateMaintService) this._Channel).LoadESigDetails(this._UserProfile, packageCreationTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PackageCreationTemplateMaintMethod(packageCreationTemplateMaint, PackageCreationTemplateMaintMethods.LoadESigDetails, (PackageCreationTemplateMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) packageCreationTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PackageCreationTemplateMaint) null, (PackageCreationTemplateMaint_LoadESigDetails_Parameters) null, (PackageCreationTemplateMaint_Request) null, out PackageCreationTemplateMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PackageCreationTemplateMaint packageCreationTemplateMaint)
    {
      return this.LoadESigDetails(packageCreationTemplateMaint, (PackageCreationTemplateMaint_LoadESigDetails_Parameters) null, (PackageCreationTemplateMaint_Request) null, out PackageCreationTemplateMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      return this.LoadESigDetails(packageCreationTemplateMaint, (PackageCreationTemplateMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Parameters parameters,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      result = (PackageCreationTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) packageCreationTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageCreationTemplateMaintService) this._Channel).New(this._UserProfile, packageCreationTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PackageCreationTemplateMaintMethod(packageCreationTemplateMaint, PackageCreationTemplateMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) packageCreationTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((PackageCreationTemplateMaint) null, (PackageCreationTemplateMaint_Parameters) null, (PackageCreationTemplateMaint_Request) null, out PackageCreationTemplateMaint_Result _);
    }

    public ResultStatus New(
      PackageCreationTemplateMaint packageCreationTemplateMaint)
    {
      return this.New(packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) null, (PackageCreationTemplateMaint_Request) null, out PackageCreationTemplateMaint_Result _);
    }

    public ResultStatus New(
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      return this.New(packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Parameters parameters,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      result = (PackageCreationTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) packageCreationTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageCreationTemplateMaintService) this._Channel).NewCopy(this._UserProfile, packageCreationTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PackageCreationTemplateMaintMethod(packageCreationTemplateMaint, PackageCreationTemplateMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) packageCreationTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((PackageCreationTemplateMaint) null, (PackageCreationTemplateMaint_Parameters) null, (PackageCreationTemplateMaint_Request) null, out PackageCreationTemplateMaint_Result _);
    }

    public ResultStatus NewCopy(
      PackageCreationTemplateMaint packageCreationTemplateMaint)
    {
      return this.NewCopy(packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) null, (PackageCreationTemplateMaint_Request) null, out PackageCreationTemplateMaint_Result _);
    }

    public ResultStatus NewCopy(
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      return this.NewCopy(packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Parameters parameters,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      result = (PackageCreationTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) packageCreationTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageCreationTemplateMaintService) this._Channel).SaveAs(this._UserProfile, packageCreationTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PackageCreationTemplateMaintMethod(packageCreationTemplateMaint, PackageCreationTemplateMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) packageCreationTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((PackageCreationTemplateMaint) null, (PackageCreationTemplateMaint_Parameters) null, (PackageCreationTemplateMaint_Request) null, out PackageCreationTemplateMaint_Result _);
    }

    public ResultStatus SaveAs(
      PackageCreationTemplateMaint packageCreationTemplateMaint)
    {
      return this.SaveAs(packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) null, (PackageCreationTemplateMaint_Request) null, out PackageCreationTemplateMaint_Result _);
    }

    public ResultStatus SaveAs(
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      return this.SaveAs(packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Parameters parameters,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      result = (PackageCreationTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) packageCreationTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageCreationTemplateMaintService) this._Channel).UnFreeze(this._UserProfile, packageCreationTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new PackageCreationTemplateMaintMethod(packageCreationTemplateMaint, PackageCreationTemplateMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) packageCreationTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((PackageCreationTemplateMaint) null, (PackageCreationTemplateMaint_Parameters) null, (PackageCreationTemplateMaint_Request) null, out PackageCreationTemplateMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PackageCreationTemplateMaint packageCreationTemplateMaint)
    {
      return this.UnFreeze(packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) null, (PackageCreationTemplateMaint_Request) null, out PackageCreationTemplateMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PackageCreationTemplateMaint packageCreationTemplateMaint,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      return this.UnFreeze(packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject packageCreationTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageCreationTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Delete((PackageCreationTemplateMaint) packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) parameters, (PackageCreationTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject packageCreationTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageCreationTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((PackageCreationTemplateMaint) packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) parameters, (PackageCreationTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject packageCreationTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageCreationTemplateMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PackageCreationTemplateMaint) packageCreationTemplateMaint, (PackageCreationTemplateMaint_LoadESigDetails_Parameters) parameters, (PackageCreationTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject packageCreationTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageCreationTemplateMaint_Result result1;
        ResultStatus resultStatus = this.New((PackageCreationTemplateMaint) packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) parameters, (PackageCreationTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject packageCreationTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageCreationTemplateMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((PackageCreationTemplateMaint) packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) parameters, (PackageCreationTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject packageCreationTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageCreationTemplateMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((PackageCreationTemplateMaint) packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) parameters, (PackageCreationTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject packageCreationTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageCreationTemplateMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((PackageCreationTemplateMaint) packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) parameters, (PackageCreationTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject packageCreationTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageCreationTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Load((PackageCreationTemplateMaint) packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) parameters, (PackageCreationTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject packageCreationTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageCreationTemplateMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PackageCreationTemplateMaint) packageCreationTemplateMaint, (PackageCreationTemplateMaint_Parameters) parameters, (PackageCreationTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      result = (PackageCreationTemplateMaint_Result) null;
      try
      {
        PackageCreationTemplateMaintMethod[] methods = new PackageCreationTemplateMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPackageCreationTemplateMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PackageCreationTemplateMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PackageCreationTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PackageCreationTemplateMaint cdo,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      result = (PackageCreationTemplateMaint_Result) null;
      try
      {
        return ((IPackageCreationTemplateMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PackageCreationTemplateMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((PackageCreationTemplateMaint) cdo, (PackageCreationTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      return this.GetEnvironment((PackageCreationTemplateMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PackageCreationTemplateMaint cdo,
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      result = (PackageCreationTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageCreationTemplateMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PackageCreationTemplateMaintMethod(cdo, PackageCreationTemplateMaintMethods.ExecuteTransaction, (PackageCreationTemplateMaint_Parameters) null));
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
        PackageCreationTemplateMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PackageCreationTemplateMaint) cdo, (PackageCreationTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PackageCreationTemplateMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (PackageCreationTemplateMaint_Request) null, out PackageCreationTemplateMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PackageCreationTemplateMaint_Request request,
      out PackageCreationTemplateMaint_Result result)
    {
      return this.ExecuteTransaction((PackageCreationTemplateMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PackageCreationTemplateMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PackageCreationTemplateMaintMethod(cdo, PackageCreationTemplateMaintMethods.AddDataTransaction, (PackageCreationTemplateMaint_Parameters) null));
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
        return this.AddDataTransaction((PackageCreationTemplateMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
