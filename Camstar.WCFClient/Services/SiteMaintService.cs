// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SiteMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SiteMaintService : NamedDataObjectMaintBase
  {
    public SiteMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISiteMaintService), userProfile);
    }

    public ResultStatus Delete(
      SiteMaint siteMaint,
      SiteMaint_Parameters parameters,
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      result = (SiteMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) siteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISiteMaintService) this._Channel).Delete(this._UserProfile, siteMaint, parameters, request, out result) : this.AddMethod((Method) new SiteMaintMethod(siteMaint, SiteMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) siteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((SiteMaint) null, (SiteMaint_Parameters) null, (SiteMaint_Request) null, out SiteMaint_Result _);
    }

    public ResultStatus Delete(SiteMaint siteMaint)
    {
      return this.Delete(siteMaint, (SiteMaint_Parameters) null, (SiteMaint_Request) null, out SiteMaint_Result _);
    }

    public ResultStatus Delete(
      SiteMaint siteMaint,
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      return this.Delete(siteMaint, (SiteMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      SiteMaint siteMaint,
      SiteMaint_Parameters parameters,
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      result = (SiteMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) siteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISiteMaintService) this._Channel).Freeze(this._UserProfile, siteMaint, parameters, request, out result) : this.AddMethod((Method) new SiteMaintMethod(siteMaint, SiteMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) siteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((SiteMaint) null, (SiteMaint_Parameters) null, (SiteMaint_Request) null, out SiteMaint_Result _);
    }

    public ResultStatus Freeze(SiteMaint siteMaint)
    {
      return this.Freeze(siteMaint, (SiteMaint_Parameters) null, (SiteMaint_Request) null, out SiteMaint_Result _);
    }

    public ResultStatus Freeze(
      SiteMaint siteMaint,
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      return this.Freeze(siteMaint, (SiteMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SiteMaint siteMaint,
      SiteMaint_Parameters parameters,
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      result = (SiteMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) siteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISiteMaintService) this._Channel).GetWIPMsgs(this._UserProfile, siteMaint, parameters, request, out result) : this.AddMethod((Method) new SiteMaintMethod(siteMaint, SiteMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) siteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SiteMaint) null, (SiteMaint_Parameters) null, (SiteMaint_Request) null, out SiteMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(SiteMaint siteMaint)
    {
      return this.GetWIPMsgs(siteMaint, (SiteMaint_Parameters) null, (SiteMaint_Request) null, out SiteMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SiteMaint siteMaint,
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      return this.GetWIPMsgs(siteMaint, (SiteMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SiteMaint siteMaint,
      SiteMaint_Parameters parameters,
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      result = (SiteMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) siteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISiteMaintService) this._Channel).Load(this._UserProfile, siteMaint, parameters, request, out result) : this.AddMethod((Method) new SiteMaintMethod(siteMaint, SiteMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) siteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SiteMaint) null, (SiteMaint_Parameters) null, (SiteMaint_Request) null, out SiteMaint_Result _);
    }

    public ResultStatus Load(SiteMaint siteMaint)
    {
      return this.Load(siteMaint, (SiteMaint_Parameters) null, (SiteMaint_Request) null, out SiteMaint_Result _);
    }

    public ResultStatus Load(
      SiteMaint siteMaint,
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      return this.Load(siteMaint, (SiteMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SiteMaint siteMaint,
      SiteMaint_LoadESigDetails_Parameters parameters,
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      result = (SiteMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) siteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISiteMaintService) this._Channel).LoadESigDetails(this._UserProfile, siteMaint, parameters, request, out result) : this.AddMethod((Method) new SiteMaintMethod(siteMaint, SiteMaintMethods.LoadESigDetails, (SiteMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) siteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SiteMaint) null, (SiteMaint_LoadESigDetails_Parameters) null, (SiteMaint_Request) null, out SiteMaint_Result _);
    }

    public ResultStatus LoadESigDetails(SiteMaint siteMaint)
    {
      return this.LoadESigDetails(siteMaint, (SiteMaint_LoadESigDetails_Parameters) null, (SiteMaint_Request) null, out SiteMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      SiteMaint siteMaint,
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      return this.LoadESigDetails(siteMaint, (SiteMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      SiteMaint siteMaint,
      SiteMaint_Parameters parameters,
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      result = (SiteMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) siteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISiteMaintService) this._Channel).New(this._UserProfile, siteMaint, parameters, request, out result) : this.AddMethod((Method) new SiteMaintMethod(siteMaint, SiteMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) siteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((SiteMaint) null, (SiteMaint_Parameters) null, (SiteMaint_Request) null, out SiteMaint_Result _);
    }

    public ResultStatus New(SiteMaint siteMaint)
    {
      return this.New(siteMaint, (SiteMaint_Parameters) null, (SiteMaint_Request) null, out SiteMaint_Result _);
    }

    public ResultStatus New(
      SiteMaint siteMaint,
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      return this.New(siteMaint, (SiteMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      SiteMaint siteMaint,
      SiteMaint_Parameters parameters,
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      result = (SiteMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) siteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISiteMaintService) this._Channel).NewCopy(this._UserProfile, siteMaint, parameters, request, out result) : this.AddMethod((Method) new SiteMaintMethod(siteMaint, SiteMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) siteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((SiteMaint) null, (SiteMaint_Parameters) null, (SiteMaint_Request) null, out SiteMaint_Result _);
    }

    public ResultStatus NewCopy(SiteMaint siteMaint)
    {
      return this.NewCopy(siteMaint, (SiteMaint_Parameters) null, (SiteMaint_Request) null, out SiteMaint_Result _);
    }

    public ResultStatus NewCopy(
      SiteMaint siteMaint,
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      return this.NewCopy(siteMaint, (SiteMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      SiteMaint siteMaint,
      SiteMaint_Parameters parameters,
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      result = (SiteMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) siteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISiteMaintService) this._Channel).SaveAs(this._UserProfile, siteMaint, parameters, request, out result) : this.AddMethod((Method) new SiteMaintMethod(siteMaint, SiteMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) siteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((SiteMaint) null, (SiteMaint_Parameters) null, (SiteMaint_Request) null, out SiteMaint_Result _);
    }

    public ResultStatus SaveAs(SiteMaint siteMaint)
    {
      return this.SaveAs(siteMaint, (SiteMaint_Parameters) null, (SiteMaint_Request) null, out SiteMaint_Result _);
    }

    public ResultStatus SaveAs(
      SiteMaint siteMaint,
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      return this.SaveAs(siteMaint, (SiteMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      SiteMaint siteMaint,
      SiteMaint_Parameters parameters,
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      result = (SiteMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) siteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISiteMaintService) this._Channel).UnFreeze(this._UserProfile, siteMaint, parameters, request, out result) : this.AddMethod((Method) new SiteMaintMethod(siteMaint, SiteMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) siteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((SiteMaint) null, (SiteMaint_Parameters) null, (SiteMaint_Request) null, out SiteMaint_Result _);
    }

    public ResultStatus UnFreeze(SiteMaint siteMaint)
    {
      return this.UnFreeze(siteMaint, (SiteMaint_Parameters) null, (SiteMaint_Request) null, out SiteMaint_Result _);
    }

    public ResultStatus UnFreeze(
      SiteMaint siteMaint,
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      return this.UnFreeze(siteMaint, (SiteMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject siteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SiteMaint_Result result1;
        ResultStatus resultStatus = this.Delete((SiteMaint) siteMaint, (SiteMaint_Parameters) parameters, (SiteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject siteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SiteMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((SiteMaint) siteMaint, (SiteMaint_Parameters) parameters, (SiteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject siteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SiteMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SiteMaint) siteMaint, (SiteMaint_LoadESigDetails_Parameters) parameters, (SiteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject siteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SiteMaint_Result result1;
        ResultStatus resultStatus = this.New((SiteMaint) siteMaint, (SiteMaint_Parameters) parameters, (SiteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject siteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SiteMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((SiteMaint) siteMaint, (SiteMaint_Parameters) parameters, (SiteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject siteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SiteMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((SiteMaint) siteMaint, (SiteMaint_Parameters) parameters, (SiteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject siteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SiteMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((SiteMaint) siteMaint, (SiteMaint_Parameters) parameters, (SiteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject siteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SiteMaint_Result result1;
        ResultStatus resultStatus = this.Load((SiteMaint) siteMaint, (SiteMaint_Parameters) parameters, (SiteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject siteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SiteMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SiteMaint) siteMaint, (SiteMaint_Parameters) parameters, (SiteMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      result = (SiteMaint_Result) null;
      try
      {
        SiteMaintMethod[] methods = new SiteMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISiteMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SiteMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SiteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SiteMaint cdo,
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      result = (SiteMaint_Result) null;
      try
      {
        return ((ISiteMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SiteMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((SiteMaint) cdo, (SiteMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      return this.GetEnvironment((SiteMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SiteMaint cdo,
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      result = (SiteMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISiteMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SiteMaintMethod(cdo, SiteMaintMethods.ExecuteTransaction, (SiteMaint_Parameters) null));
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
        SiteMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SiteMaint) cdo, (SiteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SiteMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (SiteMaint_Request) null, out SiteMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SiteMaint_Request request,
      out SiteMaint_Result result)
    {
      return this.ExecuteTransaction((SiteMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SiteMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SiteMaintMethod(cdo, SiteMaintMethods.AddDataTransaction, (SiteMaint_Parameters) null));
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
        return this.AddDataTransaction((SiteMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
