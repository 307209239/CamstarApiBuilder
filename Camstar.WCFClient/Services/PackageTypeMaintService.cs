// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PackageTypeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PackageTypeMaintService : UserCodeMaintBase
  {
    public PackageTypeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPackageTypeMaintService), userProfile);
    }

    public ResultStatus Delete(
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Parameters parameters,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      result = (PackageTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) packageTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageTypeMaintService) this._Channel).Delete(this._UserProfile, packageTypeMaint, parameters, request, out result) : this.AddMethod((Method) new PackageTypeMaintMethod(packageTypeMaint, PackageTypeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) packageTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((PackageTypeMaint) null, (PackageTypeMaint_Parameters) null, (PackageTypeMaint_Request) null, out PackageTypeMaint_Result _);
    }

    public ResultStatus Delete(PackageTypeMaint packageTypeMaint)
    {
      return this.Delete(packageTypeMaint, (PackageTypeMaint_Parameters) null, (PackageTypeMaint_Request) null, out PackageTypeMaint_Result _);
    }

    public ResultStatus Delete(
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      return this.Delete(packageTypeMaint, (PackageTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Parameters parameters,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      result = (PackageTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) packageTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageTypeMaintService) this._Channel).Freeze(this._UserProfile, packageTypeMaint, parameters, request, out result) : this.AddMethod((Method) new PackageTypeMaintMethod(packageTypeMaint, PackageTypeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) packageTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((PackageTypeMaint) null, (PackageTypeMaint_Parameters) null, (PackageTypeMaint_Request) null, out PackageTypeMaint_Result _);
    }

    public ResultStatus Freeze(PackageTypeMaint packageTypeMaint)
    {
      return this.Freeze(packageTypeMaint, (PackageTypeMaint_Parameters) null, (PackageTypeMaint_Request) null, out PackageTypeMaint_Result _);
    }

    public ResultStatus Freeze(
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      return this.Freeze(packageTypeMaint, (PackageTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Parameters parameters,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      result = (PackageTypeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) packageTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageTypeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, packageTypeMaint, parameters, request, out result) : this.AddMethod((Method) new PackageTypeMaintMethod(packageTypeMaint, PackageTypeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) packageTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PackageTypeMaint) null, (PackageTypeMaint_Parameters) null, (PackageTypeMaint_Request) null, out PackageTypeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(PackageTypeMaint packageTypeMaint)
    {
      return this.GetWIPMsgs(packageTypeMaint, (PackageTypeMaint_Parameters) null, (PackageTypeMaint_Request) null, out PackageTypeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      return this.GetWIPMsgs(packageTypeMaint, (PackageTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Parameters parameters,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      result = (PackageTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) packageTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageTypeMaintService) this._Channel).Load(this._UserProfile, packageTypeMaint, parameters, request, out result) : this.AddMethod((Method) new PackageTypeMaintMethod(packageTypeMaint, PackageTypeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) packageTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PackageTypeMaint) null, (PackageTypeMaint_Parameters) null, (PackageTypeMaint_Request) null, out PackageTypeMaint_Result _);
    }

    public ResultStatus Load(PackageTypeMaint packageTypeMaint)
    {
      return this.Load(packageTypeMaint, (PackageTypeMaint_Parameters) null, (PackageTypeMaint_Request) null, out PackageTypeMaint_Result _);
    }

    public ResultStatus Load(
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      return this.Load(packageTypeMaint, (PackageTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_LoadESigDetails_Parameters parameters,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      result = (PackageTypeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) packageTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageTypeMaintService) this._Channel).LoadESigDetails(this._UserProfile, packageTypeMaint, parameters, request, out result) : this.AddMethod((Method) new PackageTypeMaintMethod(packageTypeMaint, PackageTypeMaintMethods.LoadESigDetails, (PackageTypeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) packageTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PackageTypeMaint) null, (PackageTypeMaint_LoadESigDetails_Parameters) null, (PackageTypeMaint_Request) null, out PackageTypeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(PackageTypeMaint packageTypeMaint)
    {
      return this.LoadESigDetails(packageTypeMaint, (PackageTypeMaint_LoadESigDetails_Parameters) null, (PackageTypeMaint_Request) null, out PackageTypeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      return this.LoadESigDetails(packageTypeMaint, (PackageTypeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Parameters parameters,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      result = (PackageTypeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) packageTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageTypeMaintService) this._Channel).New(this._UserProfile, packageTypeMaint, parameters, request, out result) : this.AddMethod((Method) new PackageTypeMaintMethod(packageTypeMaint, PackageTypeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) packageTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((PackageTypeMaint) null, (PackageTypeMaint_Parameters) null, (PackageTypeMaint_Request) null, out PackageTypeMaint_Result _);
    }

    public ResultStatus New(PackageTypeMaint packageTypeMaint)
    {
      return this.New(packageTypeMaint, (PackageTypeMaint_Parameters) null, (PackageTypeMaint_Request) null, out PackageTypeMaint_Result _);
    }

    public ResultStatus New(
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      return this.New(packageTypeMaint, (PackageTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Parameters parameters,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      result = (PackageTypeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) packageTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageTypeMaintService) this._Channel).NewCopy(this._UserProfile, packageTypeMaint, parameters, request, out result) : this.AddMethod((Method) new PackageTypeMaintMethod(packageTypeMaint, PackageTypeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) packageTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((PackageTypeMaint) null, (PackageTypeMaint_Parameters) null, (PackageTypeMaint_Request) null, out PackageTypeMaint_Result _);
    }

    public ResultStatus NewCopy(PackageTypeMaint packageTypeMaint)
    {
      return this.NewCopy(packageTypeMaint, (PackageTypeMaint_Parameters) null, (PackageTypeMaint_Request) null, out PackageTypeMaint_Result _);
    }

    public ResultStatus NewCopy(
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      return this.NewCopy(packageTypeMaint, (PackageTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Parameters parameters,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      result = (PackageTypeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) packageTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageTypeMaintService) this._Channel).SaveAs(this._UserProfile, packageTypeMaint, parameters, request, out result) : this.AddMethod((Method) new PackageTypeMaintMethod(packageTypeMaint, PackageTypeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) packageTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((PackageTypeMaint) null, (PackageTypeMaint_Parameters) null, (PackageTypeMaint_Request) null, out PackageTypeMaint_Result _);
    }

    public ResultStatus SaveAs(PackageTypeMaint packageTypeMaint)
    {
      return this.SaveAs(packageTypeMaint, (PackageTypeMaint_Parameters) null, (PackageTypeMaint_Request) null, out PackageTypeMaint_Result _);
    }

    public ResultStatus SaveAs(
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      return this.SaveAs(packageTypeMaint, (PackageTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Parameters parameters,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      result = (PackageTypeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) packageTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageTypeMaintService) this._Channel).UnFreeze(this._UserProfile, packageTypeMaint, parameters, request, out result) : this.AddMethod((Method) new PackageTypeMaintMethod(packageTypeMaint, PackageTypeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) packageTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((PackageTypeMaint) null, (PackageTypeMaint_Parameters) null, (PackageTypeMaint_Request) null, out PackageTypeMaint_Result _);
    }

    public ResultStatus UnFreeze(PackageTypeMaint packageTypeMaint)
    {
      return this.UnFreeze(packageTypeMaint, (PackageTypeMaint_Parameters) null, (PackageTypeMaint_Request) null, out PackageTypeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PackageTypeMaint packageTypeMaint,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      return this.UnFreeze(packageTypeMaint, (PackageTypeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject packageTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageTypeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((PackageTypeMaint) packageTypeMaint, (PackageTypeMaint_Parameters) parameters, (PackageTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject packageTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageTypeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((PackageTypeMaint) packageTypeMaint, (PackageTypeMaint_Parameters) parameters, (PackageTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject packageTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageTypeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PackageTypeMaint) packageTypeMaint, (PackageTypeMaint_LoadESigDetails_Parameters) parameters, (PackageTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject packageTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageTypeMaint_Result result1;
        ResultStatus resultStatus = this.New((PackageTypeMaint) packageTypeMaint, (PackageTypeMaint_Parameters) parameters, (PackageTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject packageTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageTypeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((PackageTypeMaint) packageTypeMaint, (PackageTypeMaint_Parameters) parameters, (PackageTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject packageTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageTypeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((PackageTypeMaint) packageTypeMaint, (PackageTypeMaint_Parameters) parameters, (PackageTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject packageTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageTypeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((PackageTypeMaint) packageTypeMaint, (PackageTypeMaint_Parameters) parameters, (PackageTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject packageTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageTypeMaint_Result result1;
        ResultStatus resultStatus = this.Load((PackageTypeMaint) packageTypeMaint, (PackageTypeMaint_Parameters) parameters, (PackageTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject packageTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PackageTypeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PackageTypeMaint) packageTypeMaint, (PackageTypeMaint_Parameters) parameters, (PackageTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      result = (PackageTypeMaint_Result) null;
      try
      {
        PackageTypeMaintMethod[] methods = new PackageTypeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPackageTypeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PackageTypeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PackageTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PackageTypeMaint cdo,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      result = (PackageTypeMaint_Result) null;
      try
      {
        return ((IPackageTypeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PackageTypeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((PackageTypeMaint) cdo, (PackageTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      return this.GetEnvironment((PackageTypeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PackageTypeMaint cdo,
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      result = (PackageTypeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPackageTypeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PackageTypeMaintMethod(cdo, PackageTypeMaintMethods.ExecuteTransaction, (PackageTypeMaint_Parameters) null));
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
        PackageTypeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PackageTypeMaint) cdo, (PackageTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PackageTypeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (PackageTypeMaint_Request) null, out PackageTypeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PackageTypeMaint_Request request,
      out PackageTypeMaint_Result result)
    {
      return this.ExecuteTransaction((PackageTypeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PackageTypeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PackageTypeMaintMethod(cdo, PackageTypeMaintMethods.AddDataTransaction, (PackageTypeMaint_Parameters) null));
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
        return this.AddDataTransaction((PackageTypeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
