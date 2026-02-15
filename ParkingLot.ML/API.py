
from fastapi import FastAPI, File, UploadFile
from fastapi.responses import JSONResponse
from Model import Predict
import uvicorn

app = FastAPI()

@app.post("api/Plate/detect")
async def Detect(file: UploadFile = File(...)):
    try:
        contents = await file.read() 
        plate = Predict(contents)
        await file.close()     

        return {"plate": plate}
    
    except Exception as e:
        return JSONResponse(content={"error": str(e)}, status_code=500)


if __name__ == "__main__":
    uvicorn.run(app, host="0.0.0.0", port=5000)

