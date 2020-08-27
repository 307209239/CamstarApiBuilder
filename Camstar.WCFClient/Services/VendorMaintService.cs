// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.VendorMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class VendorMaintService : NamedDataObjectMaintBase
  {
    public VendorMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IVendorMaintService), userProfile);
    }

    public ResultStatus Delete(
      VendorMaint vendorMaint,
      VendorMaint_Parameters parameters,
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      result = (VendorMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) vendorMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVendorMaintService) this._Channel).Delete(this._UserProfile, vendorMaint, parameters, request, out result) : this.AddMethod((Method) new VendorMaintMethod(vendorMaint, VendorMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) vendorMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((VendorMaint) null, (VendorMaint_Parameters) null, (VendorMaint_Request) null, out VendorMaint_Result _);
    }

    public ResultStatus Delete(VendorMaint vendorMaint)
    {
      return this.Delete(vendorMaint, (VendorMaint_Parameters) null, (VendorMaint_Request) null, out VendorMaint_Result _);
    }

    public ResultStatus Delete(
      VendorMaint vendorMaint,
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      return this.Delete(vendorMaint, (VendorMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      VendorMaint vendorMaint,
      VendorMaint_Parameters parameters,
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      result = (VendorMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) vendorMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVendorMaintService) this._Channel).Freeze(this._UserProfile, vendorMaint, parameters, request, out result) : this.AddMethod((Method) new VendorMaintMethod(vendorMaint, VendorMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) vendorMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((VendorMaint) null, (VendorMaint_Parameters) null, (VendorMaint_Request) null, out VendorMaint_Result _);
    }

    public ResultStatus Freeze(VendorMaint vendorMaint)
    {
      return this.Freeze(vendorMaint, (VendorMaint_Parameters) null, (VendorMaint_Request) null, out VendorMaint_Result _);
    }

    public ResultStatus Freeze(
      VendorMaint vendorMaint,
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      return this.Freeze(vendorMaint, (VendorMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      VendorMaint vendorMaint,
      VendorMaint_Parameters parameters,
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      result = (VendorMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) vendorMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVendorMaintService) this._Channel).GetWIPMsgs(this._UserProfile, vendorMaint, parameters, request, out result) : this.AddMethod((Method) new VendorMaintMethod(vendorMaint, VendorMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) vendorMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((VendorMaint) null, (VendorMaint_Parameters) null, (VendorMaint_Request) null, out VendorMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(VendorMaint vendorMaint)
    {
      return this.GetWIPMsgs(vendorMaint, (VendorMaint_Parameters) null, (VendorMaint_Request) null, out VendorMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      VendorMaint vendorMaint,
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      return this.GetWIPMsgs(vendorMaint, (VendorMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      VendorMaint vendorMaint,
      VendorMaint_Parameters parameters,
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      result = (VendorMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) vendorMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVendorMaintService) this._Channel).Load(this._UserProfile, vendorMaint, parameters, request, out result) : this.AddMethod((Method) new VendorMaintMethod(vendorMaint, VendorMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) vendorMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((VendorMaint) null, (VendorMaint_Parameters) null, (VendorMaint_Request) null, out VendorMaint_Result _);
    }

    public ResultStatus Load(VendorMaint vendorMaint)
    {
      return this.Load(vendorMaint, (VendorMaint_Parameters) null, (VendorMaint_Request) null, out VendorMaint_Result _);
    }

    public ResultStatus Load(
      VendorMaint vendorMaint,
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      return this.Load(vendorMaint, (VendorMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      VendorMaint vendorMaint,
      VendorMaint_LoadESigDetails_Parameters parameters,
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      result = (VendorMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) vendorMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVendorMaintService) this._Channel).LoadESigDetails(this._UserProfile, vendorMaint, parameters, request, out result) : this.AddMethod((Method) new VendorMaintMethod(vendorMaint, VendorMaintMethods.LoadESigDetails, (VendorMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) vendorMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((VendorMaint) null, (VendorMaint_LoadESigDetails_Parameters) null, (VendorMaint_Request) null, out VendorMaint_Result _);
    }

    public ResultStatus LoadESigDetails(VendorMaint vendorMaint)
    {
      return this.LoadESigDetails(vendorMaint, (VendorMaint_LoadESigDetails_Parameters) null, (VendorMaint_Request) null, out VendorMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      VendorMaint vendorMaint,
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      return this.LoadESigDetails(vendorMaint, (VendorMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      VendorMaint vendorMaint,
      VendorMaint_Parameters parameters,
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      result = (VendorMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) vendorMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVendorMaintService) this._Channel).New(this._UserProfile, vendorMaint, parameters, request, out result) : this.AddMethod((Method) new VendorMaintMethod(vendorMaint, VendorMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) vendorMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((VendorMaint) null, (VendorMaint_Parameters) null, (VendorMaint_Request) null, out VendorMaint_Result _);
    }

    public ResultStatus New(VendorMaint vendorMaint)
    {
      return this.New(vendorMaint, (VendorMaint_Parameters) null, (VendorMaint_Request) null, out VendorMaint_Result _);
    }

    public ResultStatus New(
      VendorMaint vendorMaint,
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      return this.New(vendorMaint, (VendorMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      VendorMaint vendorMaint,
      VendorMaint_Parameters parameters,
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      result = (VendorMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) vendorMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVendorMaintService) this._Channel).NewCopy(this._UserProfile, vendorMaint, parameters, request, out result) : this.AddMethod((Method) new VendorMaintMethod(vendorMaint, VendorMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) vendorMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((VendorMaint) null, (VendorMaint_Parameters) null, (VendorMaint_Request) null, out VendorMaint_Result _);
    }

    public ResultStatus NewCopy(VendorMaint vendorMaint)
    {
      return this.NewCopy(vendorMaint, (VendorMaint_Parameters) null, (VendorMaint_Request) null, out VendorMaint_Result _);
    }

    public ResultStatus NewCopy(
      VendorMaint vendorMaint,
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      return this.NewCopy(vendorMaint, (VendorMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      VendorMaint vendorMaint,
      VendorMaint_Parameters parameters,
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      result = (VendorMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) vendorMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVendorMaintService) this._Channel).SaveAs(this._UserProfile, vendorMaint, parameters, request, out result) : this.AddMethod((Method) new VendorMaintMethod(vendorMaint, VendorMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) vendorMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((VendorMaint) null, (VendorMaint_Parameters) null, (VendorMaint_Request) null, out VendorMaint_Result _);
    }

    public ResultStatus SaveAs(VendorMaint vendorMaint)
    {
      return this.SaveAs(vendorMaint, (VendorMaint_Parameters) null, (VendorMaint_Request) null, out VendorMaint_Result _);
    }

    public ResultStatus SaveAs(
      VendorMaint vendorMaint,
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      return this.SaveAs(vendorMaint, (VendorMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      VendorMaint vendorMaint,
      VendorMaint_Parameters parameters,
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      result = (VendorMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) vendorMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVendorMaintService) this._Channel).UnFreeze(this._UserProfile, vendorMaint, parameters, request, out result) : this.AddMethod((Method) new VendorMaintMethod(vendorMaint, VendorMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) vendorMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((VendorMaint) null, (VendorMaint_Parameters) null, (VendorMaint_Request) null, out VendorMaint_Result _);
    }

    public ResultStatus UnFreeze(VendorMaint vendorMaint)
    {
      return this.UnFreeze(vendorMaint, (VendorMaint_Parameters) null, (VendorMaint_Request) null, out VendorMaint_Result _);
    }

    public ResultStatus UnFreeze(
      VendorMaint vendorMaint,
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      return this.UnFreeze(vendorMaint, (VendorMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject vendorMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VendorMaint_Result result1;
        ResultStatus resultStatus = this.Delete((VendorMaint) vendorMaint, (VendorMaint_Parameters) parameters, (VendorMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject vendorMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VendorMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((VendorMaint) vendorMaint, (VendorMaint_Parameters) parameters, (VendorMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject vendorMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VendorMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((VendorMaint) vendorMaint, (VendorMaint_LoadESigDetails_Parameters) parameters, (VendorMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject vendorMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VendorMaint_Result result1;
        ResultStatus resultStatus = this.New((VendorMaint) vendorMaint, (VendorMaint_Parameters) parameters, (VendorMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject vendorMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VendorMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((VendorMaint) vendorMaint, (VendorMaint_Parameters) parameters, (VendorMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject vendorMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VendorMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((VendorMaint) vendorMaint, (VendorMaint_Parameters) parameters, (VendorMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject vendorMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VendorMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((VendorMaint) vendorMaint, (VendorMaint_Parameters) parameters, (VendorMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject vendorMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VendorMaint_Result result1;
        ResultStatus resultStatus = this.Load((VendorMaint) vendorMaint, (VendorMaint_Parameters) parameters, (VendorMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject vendorMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        VendorMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((VendorMaint) vendorMaint, (VendorMaint_Parameters) parameters, (VendorMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      result = (VendorMaint_Result) null;
      try
      {
        VendorMaintMethod[] methods = new VendorMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IVendorMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        VendorMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((VendorMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      VendorMaint cdo,
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      result = (VendorMaint_Result) null;
      try
      {
        return ((IVendorMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        VendorMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((VendorMaint) cdo, (VendorMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      return this.GetEnvironment((VendorMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      VendorMaint cdo,
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      result = (VendorMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IVendorMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new VendorMaintMethod(cdo, VendorMaintMethods.ExecuteTransaction, (VendorMaint_Parameters) null));
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
        VendorMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((VendorMaint) cdo, (VendorMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(VendorMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (VendorMaint_Request) null, out VendorMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      VendorMaint_Request request,
      out VendorMaint_Result result)
    {
      return this.ExecuteTransaction((VendorMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(VendorMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new VendorMaintMethod(cdo, VendorMaintMethods.AddDataTransaction, (VendorMaint_Parameters) null));
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
        return this.AddDataTransaction((VendorMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
