// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.OccupationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class OccupationMaintService : UserCodeMaintBase
  {
    public OccupationMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IOccupationMaintService), userProfile);
    }

    public ResultStatus Delete(
      OccupationMaint occupationMaint,
      OccupationMaint_Parameters parameters,
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      result = (OccupationMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) occupationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOccupationMaintService) this._Channel).Delete(this._UserProfile, occupationMaint, parameters, request, out result) : this.AddMethod((Method) new OccupationMaintMethod(occupationMaint, OccupationMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) occupationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((OccupationMaint) null, (OccupationMaint_Parameters) null, (OccupationMaint_Request) null, out OccupationMaint_Result _);
    }

    public ResultStatus Delete(OccupationMaint occupationMaint)
    {
      return this.Delete(occupationMaint, (OccupationMaint_Parameters) null, (OccupationMaint_Request) null, out OccupationMaint_Result _);
    }

    public ResultStatus Delete(
      OccupationMaint occupationMaint,
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      return this.Delete(occupationMaint, (OccupationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      OccupationMaint occupationMaint,
      OccupationMaint_Parameters parameters,
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      result = (OccupationMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) occupationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOccupationMaintService) this._Channel).Freeze(this._UserProfile, occupationMaint, parameters, request, out result) : this.AddMethod((Method) new OccupationMaintMethod(occupationMaint, OccupationMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) occupationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((OccupationMaint) null, (OccupationMaint_Parameters) null, (OccupationMaint_Request) null, out OccupationMaint_Result _);
    }

    public ResultStatus Freeze(OccupationMaint occupationMaint)
    {
      return this.Freeze(occupationMaint, (OccupationMaint_Parameters) null, (OccupationMaint_Request) null, out OccupationMaint_Result _);
    }

    public ResultStatus Freeze(
      OccupationMaint occupationMaint,
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      return this.Freeze(occupationMaint, (OccupationMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      OccupationMaint occupationMaint,
      OccupationMaint_Parameters parameters,
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      result = (OccupationMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) occupationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOccupationMaintService) this._Channel).GetWIPMsgs(this._UserProfile, occupationMaint, parameters, request, out result) : this.AddMethod((Method) new OccupationMaintMethod(occupationMaint, OccupationMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) occupationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((OccupationMaint) null, (OccupationMaint_Parameters) null, (OccupationMaint_Request) null, out OccupationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(OccupationMaint occupationMaint)
    {
      return this.GetWIPMsgs(occupationMaint, (OccupationMaint_Parameters) null, (OccupationMaint_Request) null, out OccupationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      OccupationMaint occupationMaint,
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      return this.GetWIPMsgs(occupationMaint, (OccupationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      OccupationMaint occupationMaint,
      OccupationMaint_Parameters parameters,
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      result = (OccupationMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) occupationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOccupationMaintService) this._Channel).Load(this._UserProfile, occupationMaint, parameters, request, out result) : this.AddMethod((Method) new OccupationMaintMethod(occupationMaint, OccupationMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) occupationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((OccupationMaint) null, (OccupationMaint_Parameters) null, (OccupationMaint_Request) null, out OccupationMaint_Result _);
    }

    public ResultStatus Load(OccupationMaint occupationMaint)
    {
      return this.Load(occupationMaint, (OccupationMaint_Parameters) null, (OccupationMaint_Request) null, out OccupationMaint_Result _);
    }

    public ResultStatus Load(
      OccupationMaint occupationMaint,
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      return this.Load(occupationMaint, (OccupationMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      OccupationMaint occupationMaint,
      OccupationMaint_LoadESigDetails_Parameters parameters,
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      result = (OccupationMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) occupationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOccupationMaintService) this._Channel).LoadESigDetails(this._UserProfile, occupationMaint, parameters, request, out result) : this.AddMethod((Method) new OccupationMaintMethod(occupationMaint, OccupationMaintMethods.LoadESigDetails, (OccupationMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) occupationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((OccupationMaint) null, (OccupationMaint_LoadESigDetails_Parameters) null, (OccupationMaint_Request) null, out OccupationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(OccupationMaint occupationMaint)
    {
      return this.LoadESigDetails(occupationMaint, (OccupationMaint_LoadESigDetails_Parameters) null, (OccupationMaint_Request) null, out OccupationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      OccupationMaint occupationMaint,
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      return this.LoadESigDetails(occupationMaint, (OccupationMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      OccupationMaint occupationMaint,
      OccupationMaint_Parameters parameters,
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      result = (OccupationMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) occupationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOccupationMaintService) this._Channel).New(this._UserProfile, occupationMaint, parameters, request, out result) : this.AddMethod((Method) new OccupationMaintMethod(occupationMaint, OccupationMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) occupationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((OccupationMaint) null, (OccupationMaint_Parameters) null, (OccupationMaint_Request) null, out OccupationMaint_Result _);
    }

    public ResultStatus New(OccupationMaint occupationMaint)
    {
      return this.New(occupationMaint, (OccupationMaint_Parameters) null, (OccupationMaint_Request) null, out OccupationMaint_Result _);
    }

    public ResultStatus New(
      OccupationMaint occupationMaint,
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      return this.New(occupationMaint, (OccupationMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      OccupationMaint occupationMaint,
      OccupationMaint_Parameters parameters,
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      result = (OccupationMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) occupationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOccupationMaintService) this._Channel).NewCopy(this._UserProfile, occupationMaint, parameters, request, out result) : this.AddMethod((Method) new OccupationMaintMethod(occupationMaint, OccupationMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) occupationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((OccupationMaint) null, (OccupationMaint_Parameters) null, (OccupationMaint_Request) null, out OccupationMaint_Result _);
    }

    public ResultStatus NewCopy(OccupationMaint occupationMaint)
    {
      return this.NewCopy(occupationMaint, (OccupationMaint_Parameters) null, (OccupationMaint_Request) null, out OccupationMaint_Result _);
    }

    public ResultStatus NewCopy(
      OccupationMaint occupationMaint,
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      return this.NewCopy(occupationMaint, (OccupationMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      OccupationMaint occupationMaint,
      OccupationMaint_Parameters parameters,
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      result = (OccupationMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) occupationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOccupationMaintService) this._Channel).SaveAs(this._UserProfile, occupationMaint, parameters, request, out result) : this.AddMethod((Method) new OccupationMaintMethod(occupationMaint, OccupationMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) occupationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((OccupationMaint) null, (OccupationMaint_Parameters) null, (OccupationMaint_Request) null, out OccupationMaint_Result _);
    }

    public ResultStatus SaveAs(OccupationMaint occupationMaint)
    {
      return this.SaveAs(occupationMaint, (OccupationMaint_Parameters) null, (OccupationMaint_Request) null, out OccupationMaint_Result _);
    }

    public ResultStatus SaveAs(
      OccupationMaint occupationMaint,
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      return this.SaveAs(occupationMaint, (OccupationMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      OccupationMaint occupationMaint,
      OccupationMaint_Parameters parameters,
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      result = (OccupationMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) occupationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOccupationMaintService) this._Channel).UnFreeze(this._UserProfile, occupationMaint, parameters, request, out result) : this.AddMethod((Method) new OccupationMaintMethod(occupationMaint, OccupationMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) occupationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((OccupationMaint) null, (OccupationMaint_Parameters) null, (OccupationMaint_Request) null, out OccupationMaint_Result _);
    }

    public ResultStatus UnFreeze(OccupationMaint occupationMaint)
    {
      return this.UnFreeze(occupationMaint, (OccupationMaint_Parameters) null, (OccupationMaint_Request) null, out OccupationMaint_Result _);
    }

    public ResultStatus UnFreeze(
      OccupationMaint occupationMaint,
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      return this.UnFreeze(occupationMaint, (OccupationMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject occupationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OccupationMaint_Result result1;
        ResultStatus resultStatus = this.Delete((OccupationMaint) occupationMaint, (OccupationMaint_Parameters) parameters, (OccupationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject occupationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OccupationMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((OccupationMaint) occupationMaint, (OccupationMaint_Parameters) parameters, (OccupationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject occupationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OccupationMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((OccupationMaint) occupationMaint, (OccupationMaint_LoadESigDetails_Parameters) parameters, (OccupationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject occupationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OccupationMaint_Result result1;
        ResultStatus resultStatus = this.New((OccupationMaint) occupationMaint, (OccupationMaint_Parameters) parameters, (OccupationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject occupationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OccupationMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((OccupationMaint) occupationMaint, (OccupationMaint_Parameters) parameters, (OccupationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject occupationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OccupationMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((OccupationMaint) occupationMaint, (OccupationMaint_Parameters) parameters, (OccupationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject occupationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OccupationMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((OccupationMaint) occupationMaint, (OccupationMaint_Parameters) parameters, (OccupationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject occupationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OccupationMaint_Result result1;
        ResultStatus resultStatus = this.Load((OccupationMaint) occupationMaint, (OccupationMaint_Parameters) parameters, (OccupationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject occupationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OccupationMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((OccupationMaint) occupationMaint, (OccupationMaint_Parameters) parameters, (OccupationMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      result = (OccupationMaint_Result) null;
      try
      {
        OccupationMaintMethod[] methods = new OccupationMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IOccupationMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        OccupationMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((OccupationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      OccupationMaint cdo,
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      result = (OccupationMaint_Result) null;
      try
      {
        return ((IOccupationMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        OccupationMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((OccupationMaint) cdo, (OccupationMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      return this.GetEnvironment((OccupationMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      OccupationMaint cdo,
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      result = (OccupationMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOccupationMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new OccupationMaintMethod(cdo, OccupationMaintMethods.ExecuteTransaction, (OccupationMaint_Parameters) null));
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
        OccupationMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((OccupationMaint) cdo, (OccupationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(OccupationMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (OccupationMaint_Request) null, out OccupationMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      OccupationMaint_Request request,
      out OccupationMaint_Result result)
    {
      return this.ExecuteTransaction((OccupationMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(OccupationMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new OccupationMaintMethod(cdo, OccupationMaintMethods.AddDataTransaction, (OccupationMaint_Parameters) null));
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
        return this.AddDataTransaction((OccupationMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
