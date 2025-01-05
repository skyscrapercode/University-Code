<?php
// Include database connection
include 'dbconnection.php';

// Get the raw POST data
$data = json_decode(file_get_contents('php://input'), true);

// Check if data is properly received
if (!isset($data['id']) || !isset($data['status'])) {
    echo json_encode(['success' => false, 'error' => 'Invalid request data']);
    exit;
}

$id = $data['id'];
$status = $data['status'];

// Update the leave status
$sql = "UPDATE `leave` SET `LEAVE_STATUS` = ? WHERE `LEAVE_ID` = ?";
$stmt = $conn->prepare($sql);
$stmt->bind_param("si", $status, $id);

if ($stmt->execute()) {
    echo json_encode(['success' => true]);
} else {
    echo json_encode(['success' => false, 'error' => $stmt->error]);
}

$stmt->close();
$conn->close();
?>
